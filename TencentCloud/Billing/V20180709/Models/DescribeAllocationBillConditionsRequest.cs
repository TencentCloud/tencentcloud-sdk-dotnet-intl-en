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

    public class DescribeAllocationBillConditionsRequest : AbstractModel
    {
        
        /// <summary>
        /// Bill month, in the format of 2024-02, which is the current month by default if not provided
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Unique identifier of a billing unit, used for filtering
        /// </summary>
        [JsonProperty("TreeNodeUniqKeys")]
        public string[] TreeNodeUniqKeys{ get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("BillDates")]
        public string[] BillDates{ get; set; }

        /// <summary>
        /// Product code
        /// </summary>
        [JsonProperty("BusinessCodes")]
        public string[] BusinessCodes{ get; set; }

        /// <summary>
        /// User UIN
        /// </summary>
        [JsonProperty("OwnerUins")]
        public string[] OwnerUins{ get; set; }

        /// <summary>
        /// Operator UIN
        /// </summary>
        [JsonProperty("OperateUins")]
        public string[] OperateUins{ get; set; }

        /// <summary>
        /// Billing mode code
        /// </summary>
        [JsonProperty("PayModes")]
        public string[] PayModes{ get; set; }

        /// <summary>
        /// Transaction type code
        /// </summary>
        [JsonProperty("ActionTypes")]
        public string[] ActionTypes{ get; set; }

        /// <summary>
        /// Subproduct code
        /// </summary>
        [JsonProperty("ProductCodes")]
        public string[] ProductCodes{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionIds")]
        public string[] RegionIds{ get; set; }

        /// <summary>
        /// AZ ID
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Instance type code
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// Tag
        /// </summary>
        [JsonProperty("Tag")]
        public string[] Tag{ get; set; }

        /// <summary>
        /// Component type code
        /// </summary>
        [JsonProperty("ComponentCodes")]
        public string[] ComponentCodes{ get; set; }

        /// <summary>
        /// Component name code
        /// </summary>
        [JsonProperty("ItemCodes")]
        public string[] ItemCodes{ get; set; }

        /// <summary>
        /// Fuzzy search criteria
        /// </summary>
        [JsonProperty("SearchKey")]
        public string SearchKey{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectIds")]
        public ulong?[] ProjectIds{ get; set; }

        /// <summary>
        /// Cost collection type
        /// </summary>
        [JsonProperty("AllocationType")]
        public long?[] AllocationType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamArraySimple(map, prefix + "TreeNodeUniqKeys.", this.TreeNodeUniqKeys);
            this.SetParamArraySimple(map, prefix + "BillDates.", this.BillDates);
            this.SetParamArraySimple(map, prefix + "BusinessCodes.", this.BusinessCodes);
            this.SetParamArraySimple(map, prefix + "OwnerUins.", this.OwnerUins);
            this.SetParamArraySimple(map, prefix + "OperateUins.", this.OperateUins);
            this.SetParamArraySimple(map, prefix + "PayModes.", this.PayModes);
            this.SetParamArraySimple(map, prefix + "ActionTypes.", this.ActionTypes);
            this.SetParamArraySimple(map, prefix + "ProductCodes.", this.ProductCodes);
            this.SetParamArraySimple(map, prefix + "RegionIds.", this.RegionIds);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamArraySimple(map, prefix + "Tag.", this.Tag);
            this.SetParamArraySimple(map, prefix + "ComponentCodes.", this.ComponentCodes);
            this.SetParamArraySimple(map, prefix + "ItemCodes.", this.ItemCodes);
            this.SetParamSimple(map, prefix + "SearchKey", this.SearchKey);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamArraySimple(map, prefix + "AllocationType.", this.AllocationType);
        }
    }
}

