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

    public class InquiryPriceRenewDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Cloud disk ID, which can be queried by calling the [DescribeDisks](https://www.tencentcloud.com/document/product/362/16315?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DiskIds")]
        public string[] DiskIds{ get; set; }

        /// <summary>
        /// Prepaid mode, that is, settings related to the monthly subscription. Through this parameter, you can specify the purchase duration of the monthly subscribed cloud disk. If CurInstanceDeadline is specified in this parameter, it will be renewed in aligned with the sub-machine expiration time. If it is a batch renewal inquiry, this parameter corresponds one-to-one with the Disks parameter, and the number of Element (XML) must be consistent.
        /// </summary>
        [JsonProperty("DiskChargePrepaids")]
        public DiskChargePrepaid[] DiskChargePrepaids{ get; set; }

        /// <summary>
        /// Specifies the new expiry time of the CBS in the format such as 2017-12-17 00:00:00. parameter `NewDeadline` and `DiskChargePrepaids` are two ways to specify inquiry duration. one of them must be input.
        /// </summary>
        [JsonProperty("NewDeadline")]
        public string NewDeadline{ get; set; }

        /// <summary>
        /// cloud disk project ID. obtain this parameter by calling the projectId field in the return value of [DescribeProject](https://www.tencentcloud.com/document/api/651/78725?from_cn_redirect=1). if input, it is only for authentication.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIds.", this.DiskIds);
            this.SetParamArrayObj(map, prefix + "DiskChargePrepaids.", this.DiskChargePrepaids);
            this.SetParamSimple(map, prefix + "NewDeadline", this.NewDeadline);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

