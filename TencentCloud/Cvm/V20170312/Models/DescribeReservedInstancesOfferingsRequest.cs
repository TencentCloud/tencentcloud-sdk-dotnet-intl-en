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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReservedInstancesOfferingsRequest : AbstractModel
    {
        
        /// <summary>
        /// Dry run. Default value: false.
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// The offset. Default value: 0. For more information on `Offset`, see the relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The number of returned results. Default value: 20. Maximum value: 100. For more information on `Limit`, see the relevant sections in API [Introduction](https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// The maximum duration as a filter, 
        /// in seconds.
        /// Default value: 94608000.
        /// </summary>
        [JsonProperty("MaxDuration")]
        public long? MaxDuration{ get; set; }

        /// <summary>
        /// The minimum duration as a filter, 
        /// in seconds.
        /// Default value: 2592000.
        /// </summary>
        [JsonProperty("MinDuration")]
        public long? MinDuration{ get; set; }

        /// <summary>
        /// <li><strong>zone</strong></li>
        /// <p style="padding-left: 30px;">Filters by the <strong>availability zones</strong> in which the Reserved Instances can be purchased, such as ap-guangzhou-1.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: please see <a href="https://intl.cloud.tencent.com/document/product/213/6091?from_cn_redirect=1">Availability Zones</a></p>
        /// <li><strong>duration</strong></li>
        /// <p style="padding-left: 30px;">Filters by the <strong>duration</strong> of the Reserved Instance, in seconds. For example, 31536000.</p><p style="padding-left: 30px;">Type: Integer</p><p style="padding-left: 30px;">Unit: second</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: 31536000 (1 year) | 94608000 (3 years)</p>
        /// <li><strong>instance-type</strong></li>
        /// <p style="padding-left: 30px;">Filters by <strong>type of the Reserved Instance</strong>, such as `S3.MEDIUM4`.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid values: please see <a href="https://intl.cloud.tencent.com/document/product/213/11518?from_cn_redirect=1">Instance Types</a></p>
        /// <li><strong>offering-type</strong></li>
        /// <p style="padding-left: 30px;">Filters by **<strong>payment term</strong>**, such as `All Upfront`.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid value: All Upfront</p>
        /// <li><strong>product-description</strong></li>
        /// <p style="padding-left: 30px;">Filters by the <strong>platform description</strong> (operating system) of the Reserved Instance, such as `linux`.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p><p style="padding-left: 30px;">Valid value: linux</p>
        /// <li><strong>reserved-instances-offering-id</strong></li>
        /// <p style="padding-left: 30px;">Filters by <strong>Reserved Instance ID</strong>, in the form of 650c138f-ae7e-4750-952a-96841d6e9fc1.</p><p style="padding-left: 30px;">Type: String</p><p style="padding-left: 30px;">Required: no</p>
        /// Each request can have up to 10 `Filters` and 5 `Filter.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
            this.SetParamSimple(map, prefix + "MinDuration", this.MinDuration);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

