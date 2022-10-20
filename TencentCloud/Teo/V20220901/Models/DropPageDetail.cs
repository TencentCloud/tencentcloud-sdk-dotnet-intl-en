/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DropPageDetail : AbstractModel
    {
        
        /// <summary>
        /// The ID of the block page, which can be obtained from the CreateSecurityDropPage API.
        /// If 0 is passed, the default block page will be used.
        /// </summary>
        [JsonProperty("PageId")]
        public long? PageId{ get; set; }

        /// <summary>
        /// The HTTP status code of the block page. Value range: 100-600.
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// The block page file or URL.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Type of the block page. Values:
        /// <li>`file`: Block page file</li>
        /// <li>`url`: Block page URL</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

