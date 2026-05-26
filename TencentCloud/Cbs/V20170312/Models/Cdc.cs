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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cdc : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CageId")]
        public string CageId{ get; set; }

        /// <summary>
        /// Exclusive cluster status. value ranges from:<br><li>NORMAL: NORMAL;</li><br><li>CLOSED: CLOSED. at this time, the exclusive cluster will be unavailable to create new cloud disks;</li><br><li>FAULT: abnormal exclusive cluster status. at this point, the exclusive cluster will be inoperable, and the tencent cloud ops team will promptly fix the cluster;</li><br><li>ISOLATED: the exclusive cluster is ISOLATED due to not renewed timely. at this moment, the exclusive cluster will be unavailable to create new cloud disks, and the corresponding cloud disks will also be inoperable.</li>.
        /// </summary>
        [JsonProperty("CdcState")]
        public string CdcState{ get; set; }

        /// <summary>
        /// Specifies the AZ ID of the exclusive cluster.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CdcName")]
        public string CdcName{ get; set; }

        /// <summary>
        /// Specifies the capacity size of the dedicated cluster.
        /// </summary>
        [JsonProperty("CdcResource")]
        public CdcSize CdcResource{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// Exclusive cluster type. valid values: <br><li>CLOUD_BASIC: BASIC CLOUD disk cluster</li><br><li>CLOUD_PREMIUM: high-performance CLOUD block storage cluster</li><br><li>CLOUD_SSD: SSD CLOUD disk cluster.</li>.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Expiry time of the dedicated cloud disk cluster.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Creation time of the resource pool.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Number of cloud disks created in the current cluster.
        /// </summary>
        [JsonProperty("DiskNumber")]
        public ulong? DiskNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CageId", this.CageId);
            this.SetParamSimple(map, prefix + "CdcState", this.CdcState);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CdcName", this.CdcName);
            this.SetParamObj(map, prefix + "CdcResource.", this.CdcResource);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "DiskNumber", this.DiskNumber);
        }
    }
}

