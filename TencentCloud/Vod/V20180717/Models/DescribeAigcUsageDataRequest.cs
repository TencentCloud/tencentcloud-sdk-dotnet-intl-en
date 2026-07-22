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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAigcUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start date. Use the <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End date, which must be greater than or equal to the start date. Use the <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>AIGC type.</p><p>Enumeration values:</p><ul><li>Video: Video</li><li>Image: Image</li><li>Text: Text</li><li>Audio: Audio</li><li>SceneAigcVideo: Scenario-based video processing</li><li>SceneAigcImage: Scenario-based image processing</li><li>SceneAigcTime: Scenario-based processing times</li><li>TextDetail: Text detailed record</li></ul>
        /// </summary>
        [JsonProperty("AigcType")]
        public string AigcType{ get; set; }

        /// <summary>
        /// <p><b>VOD <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>API Key</p>
        /// </summary>
        [JsonProperty("APIKey")]
        public string APIKey{ get; set; }

        /// <summary>
        /// <p>API Key</p>
        /// </summary>
        [JsonProperty("APIKeys")]
        public string[] APIKeys{ get; set; }

        /// <summary>
        /// <p>Query cursor</p>
        /// </summary>
        [JsonProperty("ScrollToken")]
        public string ScrollToken{ get; set; }

        /// <summary>
        /// <p>Size per page, maximum 200, it will be truncated to 200</p>
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// <p>RequestId of the raw text. Valid at that time when AigcType is TextDetail.</p>
        /// </summary>
        [JsonProperty("ReqId")]
        public string ReqId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AigcType", this.AigcType);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "APIKey", this.APIKey);
            this.SetParamArraySimple(map, prefix + "APIKeys.", this.APIKeys);
            this.SetParamSimple(map, prefix + "ScrollToken", this.ScrollToken);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ReqId", this.ReqId);
        }
    }
}

