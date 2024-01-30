using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts
{
    public class Bus
    {
        private int busNum;
        private int cost;
        private Node<Station> node;
        public Bus(int busNum,int cost,Node<Station> node) 
        {
            this.busNum = busNum;
            this.cost = cost;
            this.node = node;
        }
        
        private int ToPay(Station start,Station end)
        {
            if (IsToPay(start, end, node))
            {
                return this.cost;
            }
            return -1;
        }
        private bool IsToPay(Station start,Station end,Node<Station> node)
        {
            Node<Station> node2 = node;
            while(node2 != null)
            {
                if(node2.GetValue() ==  start) return true;
                node2 = node2.GetNext();
            }
            return false;
        }

        public static int BusNumber(CityBuses start,Station end)
        {
            if()
        }
        public static bool IsFinish(Station end,CityBuses start,Node<Station> node)
        {
            Node<Station> node1= node;
            int countS = 0;
            int countE = 0;
            while(node1 != null)
            {
                if (node1.GetValue().Equals(start))
                {
                    countS++;
                }
                if (node1.GetValue().Equals(end))
                {
                    countE++;
                }
                node1 = node1.GetNext();
            }
            if(countS > 0 && countE > 0)
            {
                return true;
            }
            return false;
        }



    }
}
