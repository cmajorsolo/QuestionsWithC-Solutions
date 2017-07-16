using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SpencerStuart
{
    public class SafestPlaceInTheGalaxy
    {
        StreamReader input;
		StreamWriter output;
		int N;
		public class S
		{
			public int x;
			public int y;
			public int z;

			public S(int x, int y, int z)
			{
				this.x = x;
				this.y = y;
				this.z = z;
			}
		}
		List<S> s;
		int max = 1000;
		Boolean[] ok;

		public static void Main()
		{
			new SafestPlaceInTheGalaxy().run();
		}

		public void run()
		{
            input = new StreamReader("safest_place_input.txt");
			output = new StreamWriter("safest_place_output.txt");

			string contents = input.ReadToEnd();
			string[] lines = contents.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
			// The excersie doesn't say where the N and coordinates located so I assume they locates from line2 of the input file
			// T is in the first line
			int T = Int32.Parse(lines[0]);

            for (int i = 1;i<T+1;i++)
			{
                string[] words = lines[i].Split(' ');
			    N = Int32.Parse(words[0]);
                List<S> bombs = new List<S>();
				for (int j = 1; j < words.Length; j++)
				{

					string pattern = @"^(\[){1}(.*?)(\]){1}$";
					string coordinatesString = Regex.Replace(words[j], pattern, "$2");
					bombs.Add(new S(Int32.Parse(coordinatesString.Split(',')[0]), Int32.Parse(coordinatesString.Split(',')[1]), Int32.Parse(coordinatesString.Split(',')[2])));
				}
                solve(N, bombs);
				output.Flush();
			}
			output.Close();
		}

		public void solve(int n, List<S> bombs)
		{
            s = bombs;

			ok = new Boolean[8];

			int l = 0;
			int r = 3000000;

			while (l < r - 1)
			{
				int m = (l + r) / 2;
				if (search(0, max, 0, max, 0, max, m, 0))
				{
					l = m;
				}
				else
				{
					r = m;
				}

			}
			output.WriteLine(l);

		}

		public Boolean search(int minx, int maxx, int miny, int maxy, int minz, int maxz, int r, int d)
		{
			ok = ok.Select(i => true).ToArray();
			int dx = Math.Max(1, maxx - minx);
			int dy = Math.Max(1, maxy - miny);
			int dz = Math.Max(1, maxz - minz);
			int k = 0;
			for (int i = 0; i < N; i++)
			{
				int c = 0;
                k = 0;
				for (int x = minx; x <= maxx; x += dx)
				{
					for (int y = miny; y <= maxy; y += dy)
					{
						for (int z = minz; z <= maxz; z += dz)
						{
							int wd = (x - s[i].x) * (x - s[i].x) + (y - s[i].y) * (y - s[i].y) + (z - s[i].z) * (z - s[i].z);
							if (wd < r)
							{
								ok[k] = false;
								c++;
							}
							k++;
						}
					}
				}
				if (c == k)
				{
					return false;
				}
			}

			for (int i = 0; i < k; i++)
			{
				if (ok[i])
				{
					return true;
				}
			}

			if (minx == maxx || miny == maxy || minz == maxz)
			{
				return false;
			}

			switch (d % 3)
			{
				case 0:
					return search(minx, (minx + maxx) / 2, miny, maxy, minz, maxz, r, d + 1) || search((minx + maxx) / 2 + 1, maxx, miny, maxy, minz, maxz, r, d + 1);
				case 1:
					return search(minx, maxx, miny, (miny + maxy) / 2, minz, maxz, r, d + 1) || search(minx, maxx, (miny + maxy) / 2 + 1, maxy, minz, maxz, r, d + 1);
				case 2:
					return search(minx, maxx, miny, maxy, minz, (minz + maxz) / 2, r, d + 1) || search(minx, maxx, miny, maxy, (minz + maxz) / 2 + 1, maxz, r, d + 1);

			}

			return false;

		}
    }
}
