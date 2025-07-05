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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// IDs of cloud disks. The value can be obtained from the `DiskId` parameter returned by the [DescribeDisks](https://intl.cloud.tencent.com/document/product/1207/66093?from_cn_redirect=1) API. Up to 50 disks can be requested at a time.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Parameter settings for renewing the monthly subscribed cloud disk.
        /// </summary>
        [JsonProperty("RenewDiskChargePrepaid")]
        public RenewDiskChargePrepaid RenewDiskChargePrepaid{ get; set; }

        /// <summary>
        /// Whether to use the vouchers automatically. It defaults to No.
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public bool? AutoVoucher{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamObj(map, prefix + "RenewDiskChargePrepaid.", this.RenewDiskChargePrepaid);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
        }
    }
}

