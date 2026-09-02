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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWebhookReceiverRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Bot name<br>Input limits: 1-20 characters in length, tenant-unique</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Robot type<br>Enumeration values:<br>WEBHOOK: webhook type<br>SCF: function type</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Robot ID. More than 0 means modifying existing records; equal to 0 or not passed means adding new<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Webhook address<br>Input parameter limit: required when Type=WEBHOOK, length 1-2048, must be a valid http(s) URL, and intranet addresses are not allowed</p>
        /// </summary>
        [JsonProperty("WebhookAddr")]
        public string WebhookAddr{ get; set; }

        /// <summary>
        /// <p>Function region, for example, ap-guangzhou<br>Input limit: required when Type is SCF</p>
        /// </summary>
        [JsonProperty("SCFRegion")]
        public string SCFRegion{ get; set; }

        /// <summary>
        /// <p>Function namespace<br>Input parameter limit: required when Type=SCF<br>Value for reference: obtain through the DescribeSCFNamespaceList API</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>SCF function name<br>Input parameter limit: required when Type=SCF<br>Parameter value reference: obtain through the DescribeSCFFunctionList API</p>
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// <p>Function version<br>Input parameter limit: required when Type is SCF, for example $LATEST<br>Parameter value for reference: obtain through the DescribeSCFFunctionVersionList API</p>
        /// </summary>
        [JsonProperty("FunctionVersion")]
        public string FunctionVersion{ get; set; }

        /// <summary>
        /// <p>Function alias<br>Input parameter limit: required when Type=SCF, for example, $DEFAULT<br>Parameter value for reference: obtain through the DescribeSCFAliasList API</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "WebhookAddr", this.WebhookAddr);
            this.SetParamSimple(map, prefix + "SCFRegion", this.SCFRegion);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "FunctionVersion", this.FunctionVersion);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
        }
    }
}

