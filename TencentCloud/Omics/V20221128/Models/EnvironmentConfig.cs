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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvironmentConfig : AbstractModel
    {
        
        /// <summary>
        /// VPC configuration
        /// </summary>
        [JsonProperty("VPCOption")]
        public VPCOption VPCOption{ get; set; }

        /// <summary>
        /// Computing cluster configuration
        /// </summary>
        [JsonProperty("ClusterOption")]
        public ClusterOption ClusterOption{ get; set; }

        /// <summary>
        /// Database configuration
        /// </summary>
        [JsonProperty("DatabaseOption")]
        public DatabaseOption DatabaseOption{ get; set; }

        /// <summary>
        /// Storage configuration
        /// </summary>
        [JsonProperty("StorageOption")]
        public StorageOption StorageOption{ get; set; }

        /// <summary>
        /// CVM configuration
        /// </summary>
        [JsonProperty("CVMOption")]
        public CVMOption CVMOption{ get; set; }

        /// <summary>
        /// Security group configuration
        /// </summary>
        [JsonProperty("SecurityGroupOption")]
        public SecurityGroupOption SecurityGroupOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VPCOption.", this.VPCOption);
            this.SetParamObj(map, prefix + "ClusterOption.", this.ClusterOption);
            this.SetParamObj(map, prefix + "DatabaseOption.", this.DatabaseOption);
            this.SetParamObj(map, prefix + "StorageOption.", this.StorageOption);
            this.SetParamObj(map, prefix + "CVMOption.", this.CVMOption);
            this.SetParamObj(map, prefix + "SecurityGroupOption.", this.SecurityGroupOption);
        }
    }
}

