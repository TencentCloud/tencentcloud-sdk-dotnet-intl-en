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
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// MPS template type. Filter results by the MPS template type you want to query. Value:
        /// <li>Transcode: Query the transcoding template list.</li>
        /// <li>AIAnalysis: Create intelligent analysis template.</li>
        /// <li>SmartSubtitle: Create an intelligent subtitle template.</li>
        /// <li>SmartErase: Create an intelligent erasure template.</li>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// MPS queries template parameters. This parameter is used for passing through to the media processing service (MPS) to query the MPS template list from the VOD side. Currently only support querying templates of the following task types via this method:
        /// 1. Audio and video enhancement: Only support filling in the content of Definitions, Type, Name, Offset, and Limit parameters in the "retrieval transcoding template list" (https://www.tencentcloud.com/document/product/862/37593?from_cn_redirect=1) interface. Currently only support configuring the above parameters in template, other parameters not required. If other parameters are included, system will automatically ignore.
        /// 2. Intelligent Analysis: Only support filling in the content of Definitions, Type, Name, Offset, and Limit parameters from the "Search Intelligent Analysis Template List" (https://www.tencentcloud.com/document/product/862/40247?from_cn_redirect=1) interface. Currently only support configuring the above parameters in the Template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.
        /// 3. Smart subtitling: Only supports filling in the content of Definitions, Type, Name, Offset, and Limit parameters from the "Get Smart Subtitling Template List" (https://www.tencentcloud.com/document/product/862/117002?from_cn_redirect=1) interface. Currently only support configuring the above parameters in template, other parameters not required. If other parameters are included, system will automatically ignore.
        /// 4. Intelligent erasure: Only supports filling in the content of Definitions, Type, Name, Offset, and Limit parameters in the "Search intelligent erasure template list" (https://www.tencentcloud.com/document/product/862/123733?from_cn_redirect=1) interface. Currently only support configuring the above parameters in template. Other parameters are not required. If other parameters are included, the system will automatically ignore.
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

