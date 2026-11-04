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

    public class ModifyLabelRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Modify field contents (required, use together with update_mask)</p>
        /// </summary>
        [JsonProperty("Fields")]
        public LabelModifyFields Fields{ get; set; }

        /// <summary>
        /// <p>Associated knowledge base ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>ID of the tag to be modified</p>
        /// </summary>
        [JsonProperty("LabelId")]
        public string LabelId{ get; set; }

        /// <summary>
        /// <p>Field mask: specifies the fields to be modified (supported Paths: Name, TermModifyList)</p>
        /// </summary>
        [JsonProperty("UpdateMask")]
        public FieldMask UpdateMask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Fields.", this.Fields);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "LabelId", this.LabelId);
            this.SetParamObj(map, prefix + "UpdateMask.", this.UpdateMask);
        }
    }
}

