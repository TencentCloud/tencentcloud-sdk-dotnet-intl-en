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

    public class DescribeMPSTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>VOD <a href="/document/product/266/14574">application</a> ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>MPS template type. Filter results by the type of MPS template you want to query. Parameter Value:</p><li>AIAnalysis: Intelligent analysis template.</li><li>SmartSubtitle: Intelligent subtitle template.</li><li>SmartErase: Intelligent erasure template.</li><li>EmbedSubtitle: Subtitle suppression template.</li>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// <p>MPS query template parameter. This parameter is used for passing through to the media processing service (MPS) to query the MPS task template list from the VOD side. Currently, only this method is supported for querying templates of the following task types:</p><ol><li>Audio and video enhancement: only support filling in the content of the Definitions, Type, Name, Offset, and Limit parameters in the <a href="https://www.tencentcloud.com/document/product/862/37593?from_cn_redirect=1">Get transcoding template list</a> API. Currently, only the above parameters can be configured in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Intelligent analysis: only support filling in the content of the Definitions, Type, Name, Offset, and Limit parameters in the <a href="https://www.tencentcloud.com/document/product/862/40247?from_cn_redirect=1">Get intelligent analysis template list</a> API. Currently, only the above parameters can be configured in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Smart subtitling: only support filling in the content of the Definitions, Type, Name, Offset, and Limit parameters in the <a href="https://www.tencentcloud.com/document/product/862/117002?from_cn_redirect=1">Get smart subtitle template list</a> API. Currently, only the above parameters can be configured in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Intelligent erasure: only support filling in the content of the Definitions, Type, Name, Offset, and Limit parameters in the <a href="https://www.tencentcloud.com/document/product/862/123733?from_cn_redirect=1">Get intelligent erasure template list</a> API. Currently, only the above parameters can be configured in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li></ol>
        /// </summary>
        [JsonProperty("MPSDescribeTemplateParams")]
        public string MPSDescribeTemplateParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSDescribeTemplateParams", this.MPSDescribeTemplateParams);
        }
    }
}

