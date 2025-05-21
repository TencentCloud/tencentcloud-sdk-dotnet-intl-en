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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTemplateMemberRequest : AbstractModel
    {
        
        /// <summary>
        /// Parameter template instance ID, which can be the instance ID of a parameter template of the following four types: IP address, protocol port, IP address group, and protocol port group.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Information on the parameter template to be modified. The template can be of the following four types: IP address, protocol port, IP address group, and protocol port group. The type should be consistent with that of the template specified by the TemplateId parameter. The parameter sequence should be the same as that of TemplateMember, and the input parameter length should be consistent with that of TemplateMember.
        /// </summary>
        [JsonProperty("OriginalTemplateMember")]
        public MemberInfo[] OriginalTemplateMember{ get; set; }

        /// <summary>
        /// New parameter template information. The template can be of the following four types: IP address, protocol port, IP address group, and protocol port group. The type should be consistent with that of the template specified by the TemplateId parameter. The parameter sequence should be the same as that of OriginalTemplateMember, and the input parameter length should be consistent with that of OriginalTemplateMember.
        /// </summary>
        [JsonProperty("TemplateMember")]
        public MemberInfo[] TemplateMember{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamArrayObj(map, prefix + "OriginalTemplateMember.", this.OriginalTemplateMember);
            this.SetParamArrayObj(map, prefix + "TemplateMember.", this.TemplateMember);
        }
    }
}

