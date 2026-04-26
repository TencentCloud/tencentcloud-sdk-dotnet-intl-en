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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBillDownloadUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// Billing mode. Enumeration values
        /// billOverview=L0-PDF Bill
        /// Bill Summary=L1-Summary Bill	
        /// billResource=L2-Resource bill	
        /// billDetail=L3-Detailed Bill	
        /// billPack
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// Billing month
        /// Earliest start month supported is 2021-01
        /// L0-PDF&bill package does not support download for the current month. Please download the monthly bill after billing on the 1st of next month at 19:00.
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Downloaded account ID list. By default, the query returns the account statement of the current account. If the group management account needs to download the self-pay bills of member accounts, enter the member account UIN in this field.
        /// </summary>
        [JsonProperty("ChildUin")]
        public string[] ChildUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamArraySimple(map, prefix + "ChildUin.", this.ChildUin);
        }
    }
}

