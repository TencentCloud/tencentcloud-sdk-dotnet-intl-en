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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubscribeJobsRequest : AbstractModel
    {
        
        /// <summary>
        /// Subscription ID (exact match)
        /// </summary>
        [JsonProperty("SubscribeId")]
        public string SubscribeId{ get; set; }

        /// <summary>
        /// Subscription name (prefix fuzzy match)
        /// </summary>
        [JsonProperty("SubscribeName")]
        public string SubscribeName{ get; set; }

        /// <summary>
        /// Subscribed cloud database instance ID (exact match)
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Payment method. Valid values: 0 (monthly subscription); 1 (pay-as-you-go).
        /// </summary>
        [JsonProperty("PayType")]
        public long? PayType{ get; set; }

        /// <summary>
        /// Subscribed database product. Currently, cynosdbmysql, mariadb, mongodb, mysql, percona, tdpg, tdsqlpercona are supported.
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// Data subscription lifecycle status. Valid values: normal, isolating, isolated, offline, post2PrePayIng.
        /// </summary>
        [JsonProperty("Status")]
        public string[] Status{ get; set; }

        /// <summary>
        /// Data subscription status. Valid values: notStarted, checking, checkNotPass, checkPass, starting, running, error.
        /// </summary>
        [JsonProperty("SubsStatus")]
        public string[] SubsStatus{ get; set; }

        /// <summary>
        /// Starting offset for returned results. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned at a time. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Sorting order. Valid values: DESC, ASC. Default value: DESC, indicating descending by creation time.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }

        /// <summary>
        /// Tag filter condition, the relationship between multiple TagFilters is and.
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscribeId", this.SubscribeId);
            this.SetParamSimple(map, prefix + "SubscribeName", this.SubscribeName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamArraySimple(map, prefix + "SubsStatus.", this.SubsStatus);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

