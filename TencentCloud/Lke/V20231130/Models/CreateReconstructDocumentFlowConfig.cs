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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReconstructDocumentFlowConfig : AbstractModel
    {
        
        /// <summary>
        /// The returned form of a table in a markdown file: 
        /// 0: the table is returned in MD format;
        /// 1: the table is returned in HTML form.
        /// The default is 1.
        /// </summary>
        [JsonProperty("TableResultType")]
        public string TableResultType{ get; set; }

        /// <summary>
        /// The format of smart document parsing results:
        /// 0: only return full-text MD;
        /// 1: only return OCR original JSON of each page;.
        /// 2: only return MD of each page;
        /// 3: return full-text MD + OCR original JSON of each page;.
        /// 4: return full-text MD + MD of each page.
        /// The default value is 3 (return full-text MD + OCR original JSON of each page).
        /// </summary>
        [JsonProperty("ResultType")]
        public string ResultType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableResultType", this.TableResultType);
            this.SetParamSimple(map, prefix + "ResultType", this.ResultType);
        }
    }
}

