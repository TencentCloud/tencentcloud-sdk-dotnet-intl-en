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

    public class AttachDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the EMR cluster instance.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Cloud disk ID required for mounting.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Mount mode. Valid values.
        /// AUTO_RENEW: auto-renewal.
        /// ALIGN_DEADLINE: automatic alignment with the deadline.
        /// </summary>
        [JsonProperty("AlignType")]
        public string AlignType{ get; set; }

        /// <summary>
        /// List of CVM node IDs requiring mounting.
        /// </summary>
        [JsonProperty("CvmInstanceIds")]
        public string[] CvmInstanceIds{ get; set; }

        /// <summary>
        /// Whether to mount newly purchased cloud disks.
        /// </summary>
        [JsonProperty("CreateDisk")]
        public bool? CreateDisk{ get; set; }

        /// <summary>
        /// Specifications of newly purchased cloud disks.
        /// </summary>
        [JsonProperty("DiskSpec")]
        public NodeSpecDiskV2 DiskSpec{ get; set; }

        /// <summary>
        /// Optional parameter. Only mount operation is performed if this parameter is not passed. When True is passed, the CBS will be set to termination with the cloud host upon successful mounting. This is only applicable to pay-as-you-go cloud disk.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// Name list of services that can be configured when a new disk is mounted.
        /// </summary>
        [JsonProperty("SelectiveConfServices")]
        public string[] SelectiveConfServices{ get; set; }

        /// <summary>
        /// Disk billing type (1: monthly subscription, 3: committed use).
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// Disk committed use and purchase duration (only supports 12, 24, 36, 48, and 60).
        /// </summary>
        [JsonProperty("UnderWriteDuration")]
        public long? UnderWriteDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamSimple(map, prefix + "AlignType", this.AlignType);
            this.SetParamArraySimple(map, prefix + "CvmInstanceIds.", this.CvmInstanceIds);
            this.SetParamSimple(map, prefix + "CreateDisk", this.CreateDisk);
            this.SetParamObj(map, prefix + "DiskSpec.", this.DiskSpec);
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamArraySimple(map, prefix + "SelectiveConfServices.", this.SelectiveConfServices);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "UnderWriteDuration", this.UnderWriteDuration);
        }
    }
}

