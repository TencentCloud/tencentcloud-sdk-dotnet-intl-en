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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachEntityOfPolicy : AbstractModel
    {
        
        /// <summary>
        /// Entity ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Entity Name
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Entity UIN
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// Type of entity association. 1: Associate by users; 2: Associate by User Groups
        /// </summary>
        [JsonProperty("RelatedType")]
        public ulong? RelatedType{ get; set; }

        /// <summary>
        /// Policy association time
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AttachmentTime")]
        public string AttachmentTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "RelatedType", this.RelatedType);
            this.SetParamSimple(map, prefix + "AttachmentTime", this.AttachmentTime);
        }
    }
}

