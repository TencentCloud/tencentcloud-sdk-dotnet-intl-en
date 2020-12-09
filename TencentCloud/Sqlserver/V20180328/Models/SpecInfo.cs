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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpecInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance specification ID. The `SpecId` returned by `DescribeZones` together with the purchasable specification information returned by `DescribeProductConfig` can be used to find out what specifications can be purchased in a specified AZ
        /// </summary>
        [JsonProperty("SpecId")]
        public long? SpecId{ get; set; }

        /// <summary>
        /// Model ID
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Model name
        /// </summary>
        [JsonProperty("MachineTypeName")]
        public string MachineTypeName{ get; set; }

        /// <summary>
        /// Database version information. Valid values: 2008R2 (SQL Server 2008 Enterprise), 2012SP3 (SQL Server 2012 Enterprise), 2016SP1 (SQL Server 2016 Enterprise), 201602 (SQL Server 2016 Standard), 2017 (SQL Server 2017 Enterprise)
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// Version name corresponding to the `Version` field
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// Memory size in GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Number of CPU cores
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// Minimum disk size under this specification in GB
        /// </summary>
        [JsonProperty("MinStorage")]
        public long? MinStorage{ get; set; }

        /// <summary>
        /// Maximum disk size under this specification in GB
        /// </summary>
        [JsonProperty("MaxStorage")]
        public long? MaxStorage{ get; set; }

        /// <summary>
        /// QPS of this specification
        /// </summary>
        [JsonProperty("QPS")]
        public long? QPS{ get; set; }

        /// <summary>
        /// Description of this specification
        /// </summary>
        [JsonProperty("SuitInfo")]
        public string SuitInfo{ get; set; }

        /// <summary>
        /// Pid of this specification
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// Pay-as-you-go Pid list corresponding to this specification
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PostPid")]
        public long?[] PostPid{ get; set; }

        /// <summary>
        /// Billing mode under this specification. POST: pay-as-you-go
        /// </summary>
        [JsonProperty("PayModeStatus")]
        public string PayModeStatus{ get; set; }

        /// <summary>
        /// Instance type. Valid values: HA (High-Availability Edition, including dual-server high availability and AlwaysOn cluster), RO (read-only replica), SI (Basic Edition)
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Whether multi-AZ deployment is supported. Valid values: MultiZones (only multi-AZ deployment is supported), SameZones (only single-AZ deployment is supported), ALL (both deployments are supported)
        /// </summary>
        [JsonProperty("MultiZonesStatus")]
        public string MultiZonesStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineTypeName", this.MachineTypeName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "MinStorage", this.MinStorage);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "QPS", this.QPS);
            this.SetParamSimple(map, prefix + "SuitInfo", this.SuitInfo);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamArraySimple(map, prefix + "PostPid.", this.PostPid);
            this.SetParamSimple(map, prefix + "PayModeStatus", this.PayModeStatus);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MultiZonesStatus", this.MultiZonesStatus);
        }
    }
}

