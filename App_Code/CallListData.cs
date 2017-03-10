using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class CallListData
{
    private List<CustomerData> callList;
	public CallListData()
	{
        callList = new List<CustomerData>();
	}

    public void add(CustomerData c)
    {
        callList.Add(c);
    }

    public void RemoveAt(int index)
    {
        callList.RemoveAt(index);
    }

    public void clearAllCustomers()
    {
        callList.Clear();
    }

    public CustomerData getCustomerByIndex(int index)
    {
       // Customer c=null;
       // if (index < 0 || index >= numItems()) return null;        
        //return callList[index]; 
        return callList.ElementAt(index);
    }

    public Boolean isPresent(CustomerData c)
    {
        // cycle through all items and find it
        if (callList.Count == 0 || c==null) return false;

        for (int x = 0; x<callList.Count; x++)
        {
            if (callList[x].getCustomerId().Equals(c.getCustomerId()))
                return true;
        }
        return false;
    }

    public static CallListData getCallList()
    {
        CallListData cList = (CallListData)HttpContext.Current.Session["cList"];
        if (cList == null) 
            HttpContext.Current.Session["cList"] = new CallListData();
        return (CallListData)HttpContext.Current.Session["cList"];
    }

    public int numItems()
    {
        return callList.Count;
    }
   

}