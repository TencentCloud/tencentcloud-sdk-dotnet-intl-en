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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RevokePrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// Resource array. data source is ResourceType and ResourceUri in the Resource of the ListPermissions API response.
        /// </summary>
        [JsonProperty("Resources")]
        public PrivilegeResource[] Resources{ get; set; }

        /// <summary>
        /// Authorization revoked principal array. need to pay attention to parameter assembly.
        /// 1. for SubjectType and SubjectValues, refer to SubjectType and SubjectValue in SubjectDetails returned by the ListPermissions api.
        /// 2. during batch reclamation, the length of the Subjects array must match the length of the Privileges permission point, and the data must have a one-to-one correspondence.
        /// </summary>
        [JsonProperty("Subjects")]
        public Subject[] Subjects{ get; set; }

        /// <summary>
        /// Permission point, Name originates from the Name in PermissionDetails of the ListPermissions API response, such as BROWSE, GRANT_PRIVILEGES.
        /// </summary>
        [JsonProperty("Privileges")]
        public PrivilegeInfo[] Privileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamArrayObj(map, prefix + "Subjects.", this.Subjects);
            this.SetParamArrayObj(map, prefix + "Privileges.", this.Privileges);
        }
    }
}

