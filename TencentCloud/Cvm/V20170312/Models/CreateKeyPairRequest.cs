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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateKeyPairRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of the key pair, which can contain numbers, letters, and underscores, with a maximum length of 25 characters.
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// The ID of the project to which the new key pair belongs.
        /// You can query the project IDs in two ways:
        /// <li>Query the project IDs in the project list.
        /// <li>Call `DescribeProject` and look for `projectId` in the response.
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

