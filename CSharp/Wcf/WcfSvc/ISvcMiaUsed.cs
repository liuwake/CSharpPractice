﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//namespace WcfService1
//{
//    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ISvcMiaUsed”。
//    [ServiceContract]
//    public interface ISvcMiaUsed
//    {

//        [OperationContract]
//        string GetData(int value);

//        [OperationContract]
//        CompositeType GetDataUsingDataContract(CompositeType composite);

//        // TODO: 在此添加您的服务操作
//    }


//    // 使用下面示例中说明的数据约定将复合类型添加到服务操作。
//    [DataContract]
//    public class CompositeType
//    {
//        bool boolValue = true;
//        string stringValue = "Hello ";

//        [DataMember]
//        public bool BoolValue
//        {
//            get { return boolValue; }
//            set { boolValue = value; }
//        }

//        [DataMember]
//        public string StringValue
//        {
//            get { return stringValue; }
//            set { stringValue = value; }
//        }
//    }

//}

namespace WcfSvc
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IServiceDemo”。
    [ServiceContract]
    public interface ISvcMiaUsed
    {
        [OperationContract]
        String GetHello();

        [OperationContract]
        String TestMethodStr(int i);

        [OperationContract]
        int GetAdd(int a, int b);

        [OperationContract]
        string GetJson();

        [OperationContract]
        string GetImageScanResult();

        [OperationContract]
        string GetImageScanRaw();

        [OperationContract]
        string GetScan();

        //[OperationContract]
        //Int32 TestMethodInt(int i);

        //[OperationContract]
        //Double TestMethodDou(int i, int j);

    }
}