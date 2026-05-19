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

    public class ModifyWordSampleRequest : AbstractModel
    {
        
        /// <summary>
        /// Keyword, length limit: 128 characters.
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// <b>On-demand [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate on-demand services from December 25, 2023 must fill this field with the app ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <b>Keyword application scenario, available values: </b>
        /// 1. Recognition.Ocr: Perform content recognition using OCR.
        /// 2. Recognition.Asr: Perform content recognition using audio recognition technology.
        /// 3. Review.Ocr: Perform inappropriate content recognition using OCR.
        /// 4. Review.Asr: Perform inappropriate content recognition using audio recognition technology.
        /// <b>Can be abbreviated as:</b>
        /// 5. Recognition: Perform content recognition using OCR and audio recognition technology, equivalent to 1+2.
        /// 6. Review: Perform inappropriate content recognition using OCR and audio recognition technology, equivalent to 3+4.
        /// 7. All: Include all of the above, equivalent to 1+2+3+4.
        /// </summary>
        [JsonProperty("Usages")]
        public string[] Usages{ get; set; }

        /// <summary>
        /// Tag operation information.
        /// </summary>
        [JsonProperty("TagOperationInfo")]
        public AiSampleTagOperation TagOperationInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "Usages.", this.Usages);
            this.SetParamObj(map, prefix + "TagOperationInfo.", this.TagOperationInfo);
        }
    }
}

