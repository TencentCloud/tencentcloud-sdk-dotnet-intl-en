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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCustomerOwnCostExplorerSummaryRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Classification dimension</p><p>Enumeration value:</p><ul><li>Default: Default dimension</li><li>Business: Product</li><li>Product: Subproduct</li><li>Region: Region</li><li>Zone: Availability zone</li><li>ActionType: Transaction type</li><li>PayMode: Payment mode</li><li>Project: Project</li><li>PayerUin: Payer uin</li><li>OwnerUin: Owner uin</li><li>Tag: Tag</li></ul>
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// <p>Fee type</p><p>Enumeration value:</p><ul><li>originalCost: Original Cost</li><li>totalCost: Total Cost</li></ul>
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType{ get; set; }

        /// <summary>
        /// <p>Billing mode</p><p>Enumeration value:</p><ul><li>1: Billing statement</li></ul>
        /// </summary>
        [JsonProperty("BillType")]
        public long? BillType{ get; set; }

        /// <summary>
        /// <p>Start time</p><p>Parameter format: YYYY-MM-DD hh:mm:ss, for example 2006-01-02 00:00:00</p><p>Input limit: When PeriodType is month, the time range is 6 calendar months; when PeriodType is day, the time range is 2 calendar months;</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time</p><p>Parameter format: YYYY-MM-DD hh:mm:ss, for example 2006-01-02 00:00:00</p><p>Input limit: When PeriodType is month, the time range is 6 calendar months. When PeriodType is day, the time range is 2 calendar months.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Time type</p><p>Enumeration value:</p><ul><li>day: By day</li><li>month: By month</li></ul>
        /// </summary>
        [JsonProperty("PeriodType")]
        public string PeriodType{ get; set; }

        /// <summary>
        /// <p>Page number</p><p>Value range: [1, 10000]</p>
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// <p>Page size</p><p>Value range: [1, 200]</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// <p>Tag key of the statistical dimension. When Dimension is Tag, TagKey is required.</p>
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// Filter
        /// 
        /// You can pass the data returned by [DescribeCustomerOwnCostExplorerFilter](https://www.tencentcloud.com/document/product/1085/80125) as a parameter to filter the data.
        /// </summary>
        [JsonProperty("Filter")]
        public CostAnalyzeFilter Filter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamSimple(map, prefix + "FeeType", this.FeeType);
            this.SetParamSimple(map, prefix + "BillType", this.BillType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
        }
    }
}

