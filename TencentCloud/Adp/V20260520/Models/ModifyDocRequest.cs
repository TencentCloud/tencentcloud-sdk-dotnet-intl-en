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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDocRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Document ID</p>
        /// </summary>
        [JsonProperty("DocId")]
        public string DocId{ get; set; }

        /// <summary>
        /// <p>Modify field contents (required, used together with update_mask)</p>
        /// </summary>
        [JsonProperty("Fields")]
        public DocModifyFields Fields{ get; set; }

        /// <summary>
        /// <p>ID of the knowledge base it belongs to</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Field mask: specifies the fields to be modified (supported Paths: Name, CategoryId, EffectiveDomain, LabelRefList, ExternalLink, ExpirationPolicy, UpdatePeriod, Switch, ParseConfig, UserAccessConfig)</p>
        /// </summary>
        [JsonProperty("UpdateMask")]
        public FieldMask UpdateMask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DocId", this.DocId);
            this.SetParamObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamObj(map, prefix + "UpdateMask.", this.UpdateMask);
        }
    }
}

