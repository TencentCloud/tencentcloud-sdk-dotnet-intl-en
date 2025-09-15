/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceNodeDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// Process node IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Process type.
        /// </summary>
        [JsonProperty("NodeType")]
        public long? NodeType{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Service component status
        /// </summary>
        [JsonProperty("ServiceStatus")]
        public long? ServiceStatus{ get; set; }

        /// <summary>
        /// Process monitoring status
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public long? MonitorStatus{ get; set; }

        /// <summary>
        /// Service component status
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Process port information
        /// </summary>
        [JsonProperty("PortsInfo")]
        public string PortsInfo{ get; set; }

        /// <summary>
        /// Last restart time.
        /// </summary>
        [JsonProperty("LastRestartTime")]
        public string LastRestartTime{ get; set; }

        /// <summary>
        /// Node type.
        /// </summary>
        [JsonProperty("Flag")]
        public long? Flag{ get; set; }

        /// <summary>
        /// Configuration group ID.
        /// </summary>
        [JsonProperty("ConfGroupId")]
        public long? ConfGroupId{ get; set; }

        /// <summary>
        /// Configuration group name.
        /// </summary>
        [JsonProperty("ConfGroupName")]
        public string ConfGroupName{ get; set; }

        /// <summary>
        /// Whether the node needs to be restarted
        /// </summary>
        [JsonProperty("ConfStatus")]
        public long? ConfStatus{ get; set; }

        /// <summary>
        /// Process detection information
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ServiceDetectionInfo")]
        public ServiceProcessFunctionInfo[] ServiceDetectionInfo{ get; set; }

        /// <summary>
        /// Node type.
        /// </summary>
        [JsonProperty("NodeFlagFilter")]
        public string NodeFlagFilter{ get; set; }

        /// <summary>
        /// Process health status
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HealthStatus")]
        public HealthStatus HealthStatus{ get; set; }

        /// <summary>
        /// Whether the role supports monitoring.
        /// </summary>
        [JsonProperty("IsSupportRoleMonitor")]
        public bool? IsSupportRoleMonitor{ get; set; }

        /// <summary>
        /// Suspension policy
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StopPolicies")]
        public RestartPolicy[] StopPolicies{ get; set; }

        /// <summary>
        /// Strong validation of the API in a test environment. This strong validation doesn't exist on the current network, but it does exist in the data returned by the emrcc interface. If it’s not applied, an error will be reported. Omitting it will result in an error.
        /// </summary>
        [JsonProperty("HAState")]
        public string HAState{ get; set; }

        /// <summary>
        /// NameService name.
        /// </summary>
        [JsonProperty("NameService")]
        public string NameService{ get; set; }

        /// <summary>
        /// Whether the federation is supported.
        /// </summary>
        [JsonProperty("IsFederation")]
        public bool? IsFederation{ get; set; }

        /// <summary>
        /// Whether the DataNode is in maintenance status.
        /// </summary>
        [JsonProperty("DataNodeMaintenanceState")]
        public long? DataNodeMaintenanceState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "ServiceStatus", this.ServiceStatus);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PortsInfo", this.PortsInfo);
            this.SetParamSimple(map, prefix + "LastRestartTime", this.LastRestartTime);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "ConfGroupId", this.ConfGroupId);
            this.SetParamSimple(map, prefix + "ConfGroupName", this.ConfGroupName);
            this.SetParamSimple(map, prefix + "ConfStatus", this.ConfStatus);
            this.SetParamArrayObj(map, prefix + "ServiceDetectionInfo.", this.ServiceDetectionInfo);
            this.SetParamSimple(map, prefix + "NodeFlagFilter", this.NodeFlagFilter);
            this.SetParamObj(map, prefix + "HealthStatus.", this.HealthStatus);
            this.SetParamSimple(map, prefix + "IsSupportRoleMonitor", this.IsSupportRoleMonitor);
            this.SetParamArrayObj(map, prefix + "StopPolicies.", this.StopPolicies);
            this.SetParamSimple(map, prefix + "HAState", this.HAState);
            this.SetParamSimple(map, prefix + "NameService", this.NameService);
            this.SetParamSimple(map, prefix + "IsFederation", this.IsFederation);
            this.SetParamSimple(map, prefix + "DataNodeMaintenanceState", this.DataNodeMaintenanceState);
        }
    }
}

