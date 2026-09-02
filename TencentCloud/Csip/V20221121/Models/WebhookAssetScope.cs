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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WebhookAssetScope : AbstractModel
    {
        
        /// <summary>
        /// Asset scope type (aligned with NotifyAssetRange)
        /// Enumeration values:
        /// 1: All hosts (removable)
        /// 2: Specified hosts
        /// 3: Select by tag
        /// </summary>
        [JsonProperty("AssetRange")]
        public long? AssetRange{ get; set; }

        /// <summary>
        /// quuid list of selected hosts. It takes effect only when AssetRange=2.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Excluded host quuid list. This parameter takes effect only when AssetRange is 1.
        /// </summary>
        [JsonProperty("ExcludedInstanceIds")]
        public string[] ExcludedInstanceIds{ get; set; }

        /// <summary>
        /// Security center tag ID list. It takes effect only when AssetRange is 3.
        /// </summary>
        [JsonProperty("TagIds")]
        public long?[] TagIds{ get; set; }

        /// <summary>
        /// List of Tencent Cloud tags. It takes effect only when AssetRange is set to 3.
        /// Input parameter limitation: when AssetRange=3, TagIds and CloudTags cannot be empty at the same time.
        /// </summary>
        [JsonProperty("CloudTags")]
        public string[] CloudTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetRange", this.AssetRange);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "ExcludedInstanceIds.", this.ExcludedInstanceIds);
            this.SetParamArraySimple(map, prefix + "TagIds.", this.TagIds);
            this.SetParamArraySimple(map, prefix + "CloudTags.", this.CloudTags);
        }
    }
}

