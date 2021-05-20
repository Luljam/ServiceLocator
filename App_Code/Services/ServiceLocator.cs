using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;

/// <summary>
/// Summary description for ServiceLocator
/// </summary>
public class ServiceLocator : IServiceLocator
{
    public Dictionary<object, object> services = null;

    public ServiceLocator()
    {
        services = new Dictionary<object, object>();
        this.services.Add(typeof(ICidRepository), new CidRepository());
    }

    public T GetService<T>()
    {
        try
        {
            return (T)services[typeof(T)];
        }
        catch (KeyNotFoundException)
        {
            throw new ApplicationException("O serviço solicitado não esta registrado.");
        }
    }
}