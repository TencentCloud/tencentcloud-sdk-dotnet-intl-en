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

    public class ModifyKBRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Knowledge base ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>Writable attribute (use together with update_mask)</p>
        /// </summary>
        [JsonProperty("Spec")]
        public KBSpec Spec{ get; set; }

        /// <summary>
        /// <p>Field mask: specify the field to be modified (snake-shaped field name). Unlisted fields are ignored</p>
        /// </summary>
        [JsonProperty("UpdateMask")]
        public FieldMask UpdateMask{ get; set; }

        /// <summary>
        /// <p>Scaling operation (for hosting special operations that cannot be categorized into regular field modification, such as triggering over-limit recovery. It is effective only when 'extend_fields' is also input in update_mask. For the value, refer to KBExtendedAction: 1=trigger over-limit recovery)</p>
        /// </summary>
        [JsonProperty("ExtendFields")]
        public KBModifyExtendFields ExtendFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamObj(map, prefix + "Spec.", this.Spec);
            this.SetParamObj(map, prefix + "UpdateMask.", this.UpdateMask);
            this.SetParamObj(map, prefix + "ExtendFields.", this.ExtendFields);
        }
    }
}

