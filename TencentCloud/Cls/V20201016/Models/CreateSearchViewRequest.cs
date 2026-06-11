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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSearchViewRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>log set id</p><p>Logset to which the query view belongs. It is only used to manage the query view. Topics contained in the query view can be irrelevant to this logset.</p>
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// <p>Region of the logset</p><p>Parameter format: ap-guangzhou</p>
        /// </summary>
        [JsonProperty("LogsetRegion")]
        public string LogsetRegion{ get; set; }

        /// <summary>
        /// <p>View name</p><p>Input parameter limit: Supports up to 255 characters. Cannot contain "|" character.</p>
        /// </summary>
        [JsonProperty("ViewName")]
        public string ViewName{ get; set; }

        /// <summary>
        /// <p>View type</p><p>Enumeration value:</p><ul><li>log: Log topic</li><li>metric: Metric topic</li></ul><p>The topic type in the field of Topics should match the ViewType.</p>
        /// </summary>
        [JsonProperty("ViewType")]
        public string ViewType{ get; set; }

        /// <summary>
        /// <p>The query view contains topics, with a maximum of 10 topics.</p><p>The topic information configured in the Topics field should match the ViewType.</p>
        /// </summary>
        [JsonProperty("Topics")]
        public ViewSearchTopic[] Topics{ get; set; }

        /// <summary>
        /// <p>Custom query view id prefix</p><p>Parameter format: <code>^[a-z0-9][a-z0-9_-]{1,61}[a-z0-9]$</code></p><p>ViewId format of successfully created query view is ${ViewIdPrefix}-view</p>
        /// </summary>
        [JsonProperty("ViewIdPrefix")]
        public string ViewIdPrefix{ get; set; }

        /// <summary>
        /// <p>Description</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "LogsetRegion", this.LogsetRegion);
            this.SetParamSimple(map, prefix + "ViewName", this.ViewName);
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
            this.SetParamArrayObj(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "ViewIdPrefix", this.ViewIdPrefix);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

