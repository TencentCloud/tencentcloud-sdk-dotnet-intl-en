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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Availability zone. You can call [DescribeZones](https://intl.cloud.tencent.com/document/product/1207/57513?from_cn_redirect=1) and get the information in the `Zone` parameter re 
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Cloud disk size in GB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Cloud disk media type. Valid values: "CLOUD_PREMIUM" (premium cloud disk), "CLOUD_SSD" (SSD cloud disk).
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Parameters of monthly subscribed cloud disks
        /// </summary>
        [JsonProperty("DiskChargePrepaid")]
        public DiskChargePrepaid DiskChargePrepaid{ get; set; }

        /// <summary>
        /// Image name, which can contain up to 60 characters.
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }

        /// <summary>
        /// Number of cloud disks. Range: [1, 30]. Default value: 1.
        /// </summary>
        [JsonProperty("DiskCount")]
        public long? DiskCount{ get; set; }

        /// <summary>
        /// Specify the quota of disk backups. No quota if it’s left empty. Only one quota is allowed.
        /// </summary>
        [JsonProperty("DiskBackupQuota")]
        public long? DiskBackupQuota{ get; set; }

        /// <summary>
        /// Whether to use the vouchers automatically. It defaults to No.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }

        /// <summary>
        /// Automatically mount and initialize the data disk.
        /// </summary>
        [JsonProperty("AutoMountConfiguration")]
        public AutoMountConfiguration AutoMountConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamObj(map, prefix + "DiskChargePrepaid.", this.DiskChargePrepaid);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "DiskBackupQuota", this.DiskBackupQuota);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamObj(map, prefix + "AutoMountConfiguration.", this.AutoMountConfiguration);
        }
    }
}

