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

    public class NodeResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>Specifications type, such as S2.MEDIUM8.</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>System disk. The number of system disks does not exceed 1.</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public DiskSpecInfo[] SystemDisk{ get; set; }

        /// <summary>
        /// <p>List of tags to be bound.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Cloud data disk. The total number of cloud data disks does not exceed 15.</p>
        /// </summary>
        [JsonProperty("DataDisk")]
        public DiskSpecInfo[] DataDisk{ get; set; }

        /// <summary>
        /// <p>Local data disk.</p>
        /// </summary>
        [JsonProperty("LocalDataDisk")]
        public DiskSpecInfo[] LocalDataDisk{ get; set; }

        /// <summary>
        /// <p>Node configuration information. Currently provided only for the Terraform platform to validate parameters.</p>
        /// </summary>
        [JsonProperty("SoftwareConfig")]
        public ServiceDeploy[] SoftwareConfig{ get; set; }

        /// <summary>
        /// <p>Custom hostname.</p>
        /// </summary>
        [JsonProperty("CustomNodeName")]
        public string CustomNodeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamArrayObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamArrayObj(map, prefix + "LocalDataDisk.", this.LocalDataDisk);
            this.SetParamArrayObj(map, prefix + "SoftwareConfig.", this.SoftwareConfig);
            this.SetParamSimple(map, prefix + "CustomNodeName", this.CustomNodeName);
        }
    }
}

