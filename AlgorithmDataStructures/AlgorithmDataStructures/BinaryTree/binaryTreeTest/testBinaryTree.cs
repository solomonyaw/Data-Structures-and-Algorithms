using System;
using System.IO;
using System.Text;
using SysBio.dataStructures;
using System.Runtime.InteropServices;
using System.Threading;
using System.Collections;

// Test code
// Test performance and delete method

namespace binaryTreeTest
{

	public class PerformanceTimer {

		public static readonly bool IsHighPerformance;

		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceCounter(
			out long lpPerformanceCount);

		[DllImport("Kernel32.dll")]
		private static extern bool QueryPerformanceFrequency(
			out long lpFrequency);
		private long m_startTime;
		private long m_stopTime;
		private static long m_freq;

		static PerformanceTimer() {
			try {
				IsHighPerformance =
					QueryPerformanceFrequency(out m_freq);
			}
			catch (Exception) {
				IsHighPerformance = false;
			}
		}

 		public PerformanceTimer() {
			m_startTime = 0;
			m_stopTime = 0;
		}

		/// <summary>
		/// Start the timer
		/// </summary>
		public void Start() {

			// let the waiting threads do their work
			Thread.Sleep(0);
			if (IsHighPerformance) {
				QueryPerformanceCounter(out m_startTime);
			}
			else {
				m_startTime = DateTime.Now.Ticks;
			}
		}

		/// <summary>
		/// Stop the timer
		/// </summary>
		public void Stop() {
			if (IsHighPerformance) {
				QueryPerformanceCounter(out m_stopTime);
			}
			else {
				m_stopTime = DateTime.Now.Ticks;
			}
		}

		/// <summary>
		/// Returns the duration of the timer
		/// (in fraction of seconds)
		/// </summary>         
		public double DurationSeconds {
			get {
				if (IsHighPerformance) {
					return (double)(m_stopTime - m_startTime) /
						(double)m_freq;
				}
				else {
					TimeSpan span =
						(new DateTime(m_stopTime)) -
						(new DateTime(m_startTime));
					return span.TotalSeconds;
				}
			}
		}
	}


	class Class1 {
		static string randomString(Random random, int size, bool lowerCase) {
			StringBuilder builder = new StringBuilder();
			char ch ;
			for(int i=0; i<size; i++) {
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))) ;
				builder.Append(ch);
			}
			if(lowerCase)
				return builder.ToString().ToLower();
			return builder.ToString();
		}


		[STAThread]
	    // This is the code that was used to generate the performance 
		// graphs in the codeproject article.
		static void Main(string[] args) {
			Console.WriteLine ("Start Tests");
			PerformanceTimer pt = new PerformanceTimer();
			Random random = new Random();
			TBinarySTree bt;
			Hashtable ht;

			int[] dataSizeArray = new int[22] { 1000, 5000, 10000, 20000, 30000,
													   40000, 50000, 60000, 80000,
													   100000, 120000, 140000, 160000, 180000,
													   200000, 250000, 300000, 400000, 500000, 
													   750000, 1000000, 1000000};
			const int numberOfIntervals = 22;
			string[] values = new string[10000000];  // Max number, ever
			TextWriter tw = new StreamWriter("Results.txt");
			try {
				// Number of trials in a particular interval run
				int trials = 20000;
			
				tw.WriteLine ("Start Tests, number of intervals: {0}\n", numberOfIntervals);
				tw.WriteLine ("Number of trials in each interval: {0}\n", trials);
				for (int nn=0; nn<numberOfIntervals; nn++) {
				
					Console.WriteLine ("\nNumber of symbols to insert {0}", dataSizeArray[nn]);

					// Generate the keys that will stored in the tables
					for (int i=0; i<dataSizeArray[nn]; i++)
						values[i] = randomString (random, 10, true);

					double meanBt = 0;  // Mean time for binary search tree
					double meanHt = 0;  // Mean time for hash table
					int index;

					double[] timeBt = new double[trials];
					double[] timeHt = new double[trials];
 
					// Insert data into binary search tree
					bt = new TBinarySTree();
					for (int i=0; i<dataSizeArray[nn]; i++)
						bt.insert (values[i], i);

					// Insert data into hash table
					ht = new Hashtable();
					for (int i=0; i<dataSizeArray[nn]; i++)
						ht.Add(values[i], i.ToString());

					// Data in place, ready to time retrieval.

					// Retrieve data from a tree/table 'trial times' Eg 
					// retrieve 20,000 times (trials) from a
					// binary tree that contains 500,000 items (dataSizeArray)
					for (int k=0; k<trials; k++) {

						if (k % 4000 == 0) Console.WriteLine ("{0}", k.ToString());
						// Pick a value at random from the value array, 0
						// to the number of values in the dataSizeArray array.
						// Eg, assume nn = 5th trial, dataSizeArray[4] = 30000
						// We pick a number from a random location in values[0->30000]
						// and time how long to takes to retrieve it.
						// For each interval we store all the trial times, then
						// comput their average and standard deviation.
						
						// Binary Search Tree
						index = random.Next (dataSizeArray[nn]);
						pt.Start();
						bt.findSymbol (values[index]);
						pt.Stop();
						timeBt[k] = pt.DurationSeconds;
					
						// Hash Table
						index = random.Next (dataSizeArray[nn]);
						pt.Start();
						ht[values[index]].ToString();
						pt.Stop();
						timeHt[k] = pt.DurationSeconds;
					}
					// Compute the mean time
					for (int i=0; i<trials; i++) {
						meanBt = meanBt + timeBt[i];
						meanHt = meanHt + timeHt[i];
					}
					meanBt = meanBt/trials;
					meanHt = meanHt/trials;

					Console.WriteLine();
					Console.WriteLine ("\nAverage Time for Binary Tree = {0}", meanBt);
					// Compute standard deviation
					double sd = 0;
					for (int i=0; i<trials; i++)
						sd = sd + (timeBt[i] - meanBt)*(timeBt[i] - meanBt);
					sd = Math.Sqrt (sd/trials);
					// CV = coefficient of variation
					Console.WriteLine ("Standard deviation = {0}, CV = {1}", sd, sd/meanBt);

					Console.WriteLine ("\nAverage time for Hash Table = {0}", meanHt);
					sd = 0;
					for (int i=0; i<trials; i++)
						sd = sd + (timeHt[i] - meanHt)*(timeHt[i] - meanHt);
					sd = Math.Sqrt (sd/trials);
					Console.WriteLine ("Standard deviation = {0}, CV = {1}", sd, sd/meanHt);

					tw.WriteLine ("{0} {1} {2}", dataSizeArray[nn], meanBt, meanHt);
				}
			} finally {
				tw.Close();
			}

			// Deletion tests
			Console.WriteLine ("Test Deletion method\n");

			bt = new TBinarySTree ();
			bt.insert ("50", 50);
			bt.insert ("60", 60);
			bt.insert ("40", 40);
			bt.insert ("30", 30);
			bt.insert ("20", 20);
			bt.insert ("35", 35);
			bt.insert ("45", 45);
			bt.insert ("44", 44);
			bt.insert ("46", 46);
			Console.WriteLine ("Number of nodes in the tree = {0}\n", bt.count());
			
			Console.WriteLine ("Original: " + bt.drawTree());
			bt.delete ("40");
			Console.WriteLine ("Delete node 40: " + bt.drawTree());
			bt.delete ("45");
			Console.WriteLine ("Delete node 45: " + bt.drawTree());

			Console.WriteLine ("\nSimple one layered tree");
			bt = new TBinarySTree ();
			bt.insert ("50", 50);
			bt.insert ("20", 20);
			bt.insert ("90", 90);
			Console.WriteLine ("\nOriginal: " + bt.drawTree());
			bt.delete ("50");
			Console.WriteLine ("Delete node 50: " + bt.drawTree());

			bt = new TBinarySTree ();
			bt.insert ("50", 50);
			bt.insert ("20", 20);
			bt.insert ("90", 90);
			Console.WriteLine ("\nOriginal: " + bt.drawTree());
			bt.delete ("20");
			Console.WriteLine ("Delete node 20: " + bt.drawTree());

			bt = new TBinarySTree ();
			bt.insert ("50", 50);
			bt.insert ("20", 20);
			bt.insert ("90", 90);
			Console.WriteLine ("\nOriginal: " + bt.drawTree());
			bt.delete ("90");
			Console.WriteLine ("Delete node 90: " + bt.drawTree());
			bt.delete ("20");
			Console.WriteLine ("Delete node 20: " + bt.drawTree());
			bt.delete ("50");
			Console.WriteLine ("Delete node 50: " + bt.drawTree());

			Console.WriteLine ("\n");
			bt = new TBinarySTree ();
			bt.insert ("L", 1);
			bt.insert ("D", 2);
			bt.insert ("C", 3);
			bt.insert ("A", 4);
			bt.insert ("H", 5);
			bt.insert ("F", 6);
			bt.insert ("J", 7);
			bt.insert ("P", 8);
			Console.WriteLine ("Original: " + bt.drawTree());
			bt.delete ("J");
			Console.WriteLine ("Delete J: " + bt.drawTree());
			bt.delete ("C");
			Console.WriteLine ("Delete C: " + bt.drawTree());
			bt.delete ("L");
			Console.WriteLine ("Delete L: " + bt.drawTree());
			bt.delete ("D");
			Console.WriteLine ("Delete D: " + bt.drawTree());
			bt.delete ("A");
			Console.WriteLine ("Delete A: " + bt.drawTree());

			Console.ReadLine();
		}
	}
}
