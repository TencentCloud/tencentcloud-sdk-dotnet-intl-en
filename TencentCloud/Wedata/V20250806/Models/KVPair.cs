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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KVPair : AbstractModel
    {
        
        /// <summary>
        /// Key name
        /// 
        /// </summary>
        [JsonProperty("K")]
        public string K{ get; set; }

        /// <summary>
        /// The value. do not pass SQL (the request will be deemed as an attack on the api). if needed, transcode the SQL with Base64 and decode it.
        /// </summary>
        [JsonProperty("V")]
        public string V{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "K", this.K);
            this.SetParamSimple(map, prefix + "V", this.V);
        }
    }
}

