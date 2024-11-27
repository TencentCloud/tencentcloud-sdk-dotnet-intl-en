/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClbObject : AbstractModel
    {
        
        /// <summary>
        /// Object ID
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Precise Domain List
        /// </summary>
        [JsonProperty("PreciseDomains")]
        public string[] PreciseDomains{ get; set; }

        /// <summary>
        /// WAF Feature Switch Status, 0 Off 1 On
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// WAF Log Switch Status, 0 Off 1 On
        /// </summary>
        [JsonProperty("ClsStatus")]
        public long? ClsStatus{ get; set; }

        /// <summary>
        /// Virtual Domain Name Corresponding to CLB Object
        /// </summary>
        [JsonProperty("VirtualDomain")]
        public string VirtualDomain{ get; set; }

        /// <summary>
        /// Object name
        /// </summary>
        [JsonProperty("ObjectName")]
        public string ObjectName{ get; set; }

        /// <summary>
        /// Public network address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string[] PublicIp{ get; set; }

        /// <summary>
        /// Private network address
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string[] PrivateIp{ get; set; }

        /// <summary>
        /// VPC name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// WAF instance level, if no instance is bound, it is 0
        /// </summary>
        [JsonProperty("InstanceLevel")]
        public long? InstanceLevel{ get; set; }

        /// <summary>
        /// CLB Shipping Switch
        /// </summary>
        [JsonProperty("PostCLSStatus")]
        public long? PostCLSStatus{ get; set; }

        /// <summary>
        /// Kafka Shipping Switch
        /// </summary>
        [JsonProperty("PostCKafkaStatus")]
        public long? PostCKafkaStatus{ get; set; }

        /// <summary>
        /// Object type: CLB: Load Balancer, TSE: Cloud-native Gateway
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Object Region
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Proxy status. 0: disabled; 1: Use the first IP address in XFF as the client IP address; 2: Use remote_addr as the client IP address; 3: Obtain the client IP address from the specified header field. The field is given by the IpHeaders field.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Proxy")]
        public ulong? Proxy{ get; set; }

        /// <summary>
        /// List of header fields for obtaining the client IP. This parameter is effective when IsCdn is 3.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// Bot protection switch
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BotStatus")]
        public long? BotStatus{ get; set; }

        /// <summary>
        /// API protection switch
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiStatus")]
        public long? ApiStatus{ get; set; }

        /// <summary>
        /// Object access mode. 0: image mode; 1: cleaning mode; 2: examination mode. By default, the cleaning mode is used.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectFlowMode")]
        public long? ObjectFlowMode{ get; set; }

        /// <summary>
        /// VPC ID in numerical format
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public long? NumericalVpcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "PreciseDomains.", this.PreciseDomains);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "VirtualDomain", this.VirtualDomain);
            this.SetParamSimple(map, prefix + "ObjectName", this.ObjectName);
            this.SetParamArraySimple(map, prefix + "PublicIp.", this.PublicIp);
            this.SetParamArraySimple(map, prefix + "PrivateIp.", this.PrivateIp);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamSimple(map, prefix + "InstanceLevel", this.InstanceLevel);
            this.SetParamSimple(map, prefix + "PostCLSStatus", this.PostCLSStatus);
            this.SetParamSimple(map, prefix + "PostCKafkaStatus", this.PostCKafkaStatus);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Proxy", this.Proxy);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "BotStatus", this.BotStatus);
            this.SetParamSimple(map, prefix + "ApiStatus", this.ApiStatus);
            this.SetParamSimple(map, prefix + "ObjectFlowMode", this.ObjectFlowMode);
            this.SetParamSimple(map, prefix + "NumericalVpcId", this.NumericalVpcId);
        }
    }
}

