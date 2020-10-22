﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Abiturient
{
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET.Business.LINQProvider;
    using System;
    using System.Linq;
    using System.Xml;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// БизнесЛогика.
    /// </summary>
    // *** Start programmer edit section *** (БизнесЛогика CustomAttributes)

    // *** End programmer edit section *** (БизнесЛогика CustomAttributes)
    [ICSSoft.STORMNET.AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class БизнесЛогика : ICSSoft.STORMNET.Business.BusinessServer
    {
        
        // *** Start programmer edit section *** (БизнесЛогика CustomMembers)
        
        // *** End programmer edit section *** (БизнесЛогика CustomMembers)

        
        // *** Start programmer edit section *** (OnUpdateЗаписьВЗаявлении CustomAttributes)

        // *** End programmer edit section *** (OnUpdateЗаписьВЗаявлении CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateЗаписьВЗаявлении(IIS.Abiturient.ЗаписьВЗаявлении UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateЗаписьВЗаявлении)
            if (UpdatedObject.Приоритет > 3)
                throw new Exception("Приоритет не может быть больше трех");
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var записьвзаявлении = ds.Query<ЗаписьВЗаявлении>(ЗаписьВЗаявлении.Views.ЗаписьВЗаявленииE)
                                 .Count(k => k.Специальность.__PrimaryKey == UpdatedObject.Специальность.__PrimaryKey
                                          && k.Приоритет == UpdatedObject.Приоритет);
            return new ICSSoft.STORMNET.DataObject[0];
            // *** End programmer edit section *** (OnUpdateЗаписьВЗаявлении)
        }
        
        // *** Start programmer edit section *** (OnUpdateЗаявление CustomAttributes)
        
        // *** End programmer edit section *** (OnUpdateЗаявление CustomAttributes)
        public virtual ICSSoft.STORMNET.DataObject[] OnUpdateЗаявление(IIS.Abiturient.Заявление UpdatedObject)
        {
            // *** Start programmer edit section *** (OnUpdateЗаявление)
            
                DateTime NewDate = new DateTime(2020, 05, 01);
                DateTime EndDate = new DateTime(2020, 07, 31);
                if (UpdatedObject.ДатаПодачи < NewDate)
                    throw new Exception("Выберите другую дату");
                if (UpdatedObject.ДатаПодачи > EndDate)
                    throw new Exception("Выберите другую дату");
          
            
            return new ICSSoft.STORMNET.DataObject[0];
            

            // *** End programmer edit section *** (OnUpdateЗаявление)
        }
    }
}
