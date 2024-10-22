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
        /// ID of the project to which the created key pair belongs.
        /// 
        /// You can obtain a project ID in the following ways:
        /// <li>Query the project ID through the project list.</li>
        /// <li>Call the [DescribeProjects](https://intl.cloud.tencent.com/document/api/651/78725?from_cn_redirect=1) API and obtain the `projectId` from the return information.</li>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// Tag description list. This parameter is used to bind a tag to a key pair.
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
        }
    }
}

