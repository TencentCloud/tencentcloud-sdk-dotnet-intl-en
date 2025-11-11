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

namespace TencentCloud.Lkeap.V20240522.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReconstructDocumentSSEConfig : AbstractModel
    {
        
        /// <summary>
        /// The form in which tables in a Markdown file are returned.
        /// - 0: returned as MD.
        /// - 1: returned as HTML.
        /// The default is 0.
        /// </summary>
        [JsonProperty("TableResultType")]
        public string TableResultType{ get; set; }

        /// <summary>
        /// The form in which images in a Markdown file are returned.
        /// - 0: returned as URL.
        /// - 1: only return the text content extracted from the image in markdown.
        /// The default value is 0.
        /// </summary>
        [JsonProperty("MarkdownImageResponseType")]
        public string MarkdownImageResponseType{ get; set; }

        /// <summary>
        /// Whether the Markdown file contains page number information.
        /// </summary>
        [JsonProperty("ReturnPageFormat")]
        public bool? ReturnPageFormat{ get; set; }

        /// <summary>
        /// The custom output page number style. {{p}} is a placeholder for the page number. Enable ReturnPageFormat to take effect. If empty, the default style is: <page_num>page {{p}}</page_num>.
        /// </summary>
        [JsonProperty("PageFormat")]
        public string PageFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableResultType", this.TableResultType);
            this.SetParamSimple(map, prefix + "MarkdownImageResponseType", this.MarkdownImageResponseType);
            this.SetParamSimple(map, prefix + "ReturnPageFormat", this.ReturnPageFormat);
            this.SetParamSimple(map, prefix + "PageFormat", this.PageFormat);
        }
    }
}

