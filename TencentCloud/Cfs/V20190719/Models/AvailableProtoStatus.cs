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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AvailableProtoStatus : AbstractModel
    {
        
        /// <summary>
        /// Sale status. Valid values: sale_out (sold out), saling (purchasable), no_saling (non-purchasable)
        /// </summary>
        [JsonProperty("SaleStatus")]
        public string SaleStatus{ get; set; }

        /// <summary>
        /// Protocol type. Valid values: NFS, CIFS
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SaleStatus", this.SaleStatus);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
        }
    }
}

