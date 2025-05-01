namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using System;
using Tools;
using System.Reflection;

internal class SaleImplementation : ISale
{
    string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName!;

    public int Create(Sale item)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName}");

        Sale s = item with { ProductId = DataSource.Config.SaleCode };
        DataSource.sales.Add(s);

        LogManager.WriteToLog(projectName, $"Sale with ProductId {s.ProductId} successfully created.");
        return s.ProductId;
    }

    public void Delete(int id)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} for Sale ID {id}");

        Sale? s = Read(id);
        DataSource.sales.Remove(s);

        LogManager.WriteToLog(projectName, $"Sale with ID {id} successfully deleted.");
    }

    public Sale? Read(int id)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} for Sale ID {id}");

        var isExist = DataSource.sales.FirstOrDefault(c => c.Code == id);
        if (isExist == null)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: Sale with ID {id} not found.");
            throw new dal_idIdExist("the sale not found");
        }

        LogManager.WriteToLog(projectName, $"Sale with ID {id} successfully retrieved.");
        return isExist;
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName}");

        var data = DataSource.sales.FirstOrDefault(s => filter(s));
        if (data == null)
        {
            LogManager.WriteToLog(projectName, $"Error in {functionName}: Sale matching filter not found.");
            throw new dal_objcectNotFound("the sale not found");
        }
        LogManager.WriteToLog(projectName, $"Sale matching filter successfully retrieved.");
        return data;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName}");

        var data = from s in DataSource.sales
                   where filter == null || filter(s)
                   select s;


        LogManager.WriteToLog(projectName, $"Retrieved {data.Count()} sales.");
        return data.ToList();
    }

    public void Update(Sale item)
    {
        string functionName = MethodBase.GetCurrentMethod().Name!;

        LogManager.WriteToLog(projectName, $"Starting function {functionName} for Sale ID {item.Code}");

        Delete(item.Code);
        DataSource.sales.Add(item);


        LogManager.WriteToLog(projectName, $"Sale with ID {item.Code} successfully updated.");
    }
}
