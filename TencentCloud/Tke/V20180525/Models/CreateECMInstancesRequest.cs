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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateECMInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID. Edge clusters need to enable public network access before adding ECM nodes.
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// Edge module ID
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// Instance AZ, number of instances and ISP
        /// </summary>
        [JsonProperty("ZoneInstanceCountISPSet")]
        public ECMZoneInstanceCountISP[] ZoneInstanceCountISPSet{ get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// Public network bandwidth
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// Image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Host name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Enhanced service (including CWP and Cloud Monitoring)
        /// </summary>
        [JsonProperty("EnhancedService")]
        public ECMEnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// Custom script
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// Instance extension information
        /// </summary>
        [JsonProperty("External")]
        public string External{ get; set; }

        /// <summary>
        /// Security group of the instance
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamArrayObj(map, prefix + "ZoneInstanceCountISPSet.", this.ZoneInstanceCountISPSet);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "External", this.External);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

