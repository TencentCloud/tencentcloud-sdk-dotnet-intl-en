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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSmsTemplateListRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether it is Global SMS:
        /// 0: Mainland China SMS.
        /// 1: Global SMS.
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// Array of template IDs. If the array is empty, the template list information will be queried by default (only allowed for root accounts). You need to use the `Limit` and `Offset` fields to set the query range.
        /// <dx-alert infotype="notice" title="Note">The default array length can be up to 100</dx-alert>
        /// </summary>
        [JsonProperty("TemplateIdSet")]
        public ulong?[] TemplateIdSet{ get; set; }

        /// <summary>
        /// Upper limit. Maximum value: 100.
        /// Note: it is 0 by default and is enabled when `TemplateIdSet` is empty.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Offset.
        /// Note: it is 0 by default and is enabled when `TemplateIdSet` is empty.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamArraySimple(map, prefix + "TemplateIdSet.", this.TemplateIdSet);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

