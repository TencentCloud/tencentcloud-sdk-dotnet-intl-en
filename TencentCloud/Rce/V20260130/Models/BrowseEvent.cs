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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BrowseEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>Current page type such as home page, search page</p>
        /// </summary>
        [JsonProperty("PageType")]
        public string PageType{ get; set; }

        /// <summary>
        /// <p>Currently page URL</p>
        /// </summary>
        [JsonProperty("PageUrl")]
        public string PageUrl{ get; set; }

        /// <summary>
        /// <p>Browsing duration</p><p>Measurement unit: ms</p>
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// <p>The type of the content in current page such as ad, video, article</p>
        /// </summary>
        [JsonProperty("ContentType")]
        public string ContentType{ get; set; }

        /// <summary>
        /// <p>The ID of the content in current page</p>
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// <p>Previous page type such as home page, search page</p>
        /// </summary>
        [JsonProperty("ReferPageType")]
        public string ReferPageType{ get; set; }

        /// <summary>
        /// <p>Previous page URL</p>
        /// </summary>
        [JsonProperty("ReferPageUrl")]
        public string ReferPageUrl{ get; set; }

        /// <summary>
        /// <p>The ID of the user as guest</p>
        /// </summary>
        [JsonProperty("GuestId")]
        public string GuestId{ get; set; }

        /// <summary>
        /// <p>The custom parameters agreed with RCE. An array of objects in K:V format. e.g.[{"Key": "ApproverName", "Value": "bob"},{"Key":"ApproverPhone","Value": "+86131****5678"}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageType", this.PageType);
            this.SetParamSimple(map, prefix + "PageUrl", this.PageUrl);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ContentType", this.ContentType);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamSimple(map, prefix + "ReferPageType", this.ReferPageType);
            this.SetParamSimple(map, prefix + "ReferPageUrl", this.ReferPageUrl);
            this.SetParamSimple(map, prefix + "GuestId", this.GuestId);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

