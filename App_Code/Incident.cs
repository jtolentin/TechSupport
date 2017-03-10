using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Incident
/// </summary>
public class Incident
{
    private int incidentID;
    public int IncidentID
    {
        get { return incidentID; }
        set { incidentID = value; }
    }
    
    private int customerID;
    public int CustomerID
    {
        get { return customerID; }
        set { customerID = value; }
    }

    private string productCode;
    public string ProductCode
    {
        get { return productCode; }
        set { productCode = value; }
    }

    private int techID;
    public int TechID
    {
        get { return techID; }
        set { techID = value; }
    }

    private string dateOpened;
    public string DateOpened
    {
        get { return dateOpened; }
        set { dateOpened = value; }
    }

    private string dateClosed;
    public string DateClosed
    {
        get { return dateClosed; }
        set { dateClosed = value; }
    }

    private string title;
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    private string description;
    public string Description
    {
        get { return description; }
        set { description = value; }
    }

    private string resolutionNotes;
    public string ResolutionNotes
    {
        get { return resolutionNotes; }
        set { resolutionNotes = value; }
    }

    public Incident(int inID, int custID, string proCode, int tID, string dOpen, string dClose, string ttle, string rnotes)
	{
        incidentID = inID;
        customerID = custID;
        productCode = proCode;
        techID = tID;
        dateOpened = dOpen;
        dateClosed = dClose;
        title = ttle;
        resolutionNotes = rnotes;
    }

    public string CustomerIncidentDisplay()
    {
        string dateStr = dateClosed;
        string s = "";
        s = "Incident for product " + productCode + " closed " + dateStr + " (" + title + ")";
        return s;
    }
}