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

    public class RequestBodyTransferTimeout : AbstractModel
    {
        
        /// <summary>
        /// Body transfer timeout duration. valid values: 5-120. measurement unit: seconds (s) only.
        /// </summary>
        [JsonProperty("IdleTimeout")]
        public string IdleTimeout{ get; set; }

        /// <summary>
        /// Whether body transfer timeout is enabled. valid values: <li>`on`: enable</li> <li>`off`: disable</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdleTimeout", this.IdleTimeout);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

