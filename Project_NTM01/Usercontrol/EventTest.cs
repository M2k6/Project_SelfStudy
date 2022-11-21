using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization;

namespace Project_NTM01
{
    class ProgramThree
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            Environment.Exit(0);
        }
    }

    class Counter
    {
        private int threshold;
        private int total;

        public Counter(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    }

    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
    // HOW TO : Handle events in large amount
    // The class SampleControl defines two event properties, MouseUp and MouseDown.
    class SampleControl : Component
    {
        // :
        // Define other control methods and properties.
        // :

        // Define the delegate collection.
        protected EventHandlerList listEventDelegates = new EventHandlerList();

        // Define a unique key for each event.
        static readonly object mouseDownEventKey = new object();
        static readonly object mouseUpEventKey = new object();

        // Define the MouseDown event property.
        public event MouseEventHandler MouseDown
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(mouseDownEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(mouseDownEventKey, value);
            }
        }

        // Raise the event with the delegate specified by mouseDownEventKey
        private void OnMouseDown(MouseEventArgs e)
        {
            MouseEventHandler mouseEventDelegate =
                (MouseEventHandler)listEventDelegates[mouseDownEventKey];
            mouseEventDelegate(this, e);
        }

        // Define the MouseUp event property.
        public event MouseEventHandler MouseUp
        {
            // Add the input delegate to the collection.
            add
            {
                listEventDelegates.AddHandler(mouseUpEventKey, value);
            }
            // Remove the input delegate from the collection.
            remove
            {
                listEventDelegates.RemoveHandler(mouseUpEventKey, value);
            }
        }

        // Raise the event with the delegate specified by mouseUpEventKey
        private void OnMouseUp(MouseEventArgs e)
        {
            MouseEventHandler mouseEventDelegate =
                (MouseEventHandler)listEventDelegates[mouseUpEventKey];
            mouseEventDelegate(this, e);
        }
    }
}
