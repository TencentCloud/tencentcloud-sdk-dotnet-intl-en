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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ObjectType : AbstractModel
    {
        
        /// <summary>
        /// Object type ID
        /// </summary>
        [JsonProperty("ObjectTypeId")]
        public long? ObjectTypeId{ get; set; }

        /// <summary>
        /// Object type name
        /// </summary>
        [JsonProperty("ObjectTypeTitle")]
        public string ObjectTypeTitle{ get; set; }

        /// <summary>
        /// Level-1 object type
        /// </summary>
        [JsonProperty("ObjectTypeLevelOne")]
        public string ObjectTypeLevelOne{ get; set; }

        /// <summary>
        /// Object type parameters
        /// </summary>
        [JsonProperty("ObjectTypeParams")]
        public ObjectTypeConfig ObjectTypeParams{ get; set; }

        /// <summary>
        /// JSON parsing rule for TKE APIs. If the value is null, no parsing is needed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectTypeJsonParse")]
        public ObjectTypeJsonParse ObjectTypeJsonParse{ get; set; }

        /// <summary>
        /// Whether new action is included
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectHasNewAction")]
        public bool? ObjectHasNewAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectTypeId", this.ObjectTypeId);
            this.SetParamSimple(map, prefix + "ObjectTypeTitle", this.ObjectTypeTitle);
            this.SetParamSimple(map, prefix + "ObjectTypeLevelOne", this.ObjectTypeLevelOne);
            this.SetParamObj(map, prefix + "ObjectTypeParams.", this.ObjectTypeParams);
            this.SetParamObj(map, prefix + "ObjectTypeJsonParse.", this.ObjectTypeJsonParse);
            this.SetParamSimple(map, prefix + "ObjectHasNewAction", this.ObjectHasNewAction);
        }
    }
}

