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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReturnCustomPageActionParameters : AbstractModel
    {
        
        /// <summary>
        /// Response custom status code.
        /// </summary>
        [JsonProperty("ResponseCode")]
        public string ResponseCode{ get; set; }

        /// <summary>
        /// Response custom page ID.
        /// </summary>
        [JsonProperty("ErrorPageId")]
        public string ErrorPageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResponseCode", this.ResponseCode);
            this.SetParamSimple(map, prefix + "ErrorPageId", this.ErrorPageId);
        }
    }
}

