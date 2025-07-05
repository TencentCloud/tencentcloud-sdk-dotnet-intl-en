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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrossBackupAddr : AbstractModel
    {
        
        /// <summary>
        /// The target region of cross-region backup
        /// </summary>
        [JsonProperty("CrossRegion")]
        public string CrossRegion{ get; set; }

        /// <summary>
        /// The address used to download the cross-region backup over a private network
        /// </summary>
        [JsonProperty("CrossInternalAddr")]
        public string CrossInternalAddr{ get; set; }

        /// <summary>
        /// The address used to download the cross-region backup over a public network
        /// </summary>
        [JsonProperty("CrossExternalAddr")]
        public string CrossExternalAddr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CrossRegion", this.CrossRegion);
            this.SetParamSimple(map, prefix + "CrossInternalAddr", this.CrossInternalAddr);
            this.SetParamSimple(map, prefix + "CrossExternalAddr", this.CrossExternalAddr);
        }
    }
}

