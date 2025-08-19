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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportScreenPageRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Page ID.
        /// </summary>
        [JsonProperty("PageId")]
        public string PageId{ get; set; }

        /// <summary>
        /// Canvas type. Grid canvas: GRID; Free canvas: FREE.
        /// </summary>
        [JsonProperty("CanvasType")]
        public string CanvasType{ get; set; }

        /// <summary>
        /// Image export type. Valid values: Base64, and URL (valid period: 1 day).
        /// </summary>
        [JsonProperty("PicType")]
        public string PicType{ get; set; }

        /// <summary>
        /// Component IDs. When empty, export the entire page.
        /// </summary>
        [JsonProperty("WidgetIds")]
        public string[] WidgetIds{ get; set; }

        /// <summary>
        /// Whether it is an async request.
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// Transaction ID.
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "CanvasType", this.CanvasType);
            this.SetParamSimple(map, prefix + "PicType", this.PicType);
            this.SetParamArraySimple(map, prefix + "WidgetIds.", this.WidgetIds);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
        }
    }
}

