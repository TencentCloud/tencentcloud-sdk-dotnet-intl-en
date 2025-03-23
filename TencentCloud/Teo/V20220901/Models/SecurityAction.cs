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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityAction : AbstractModel
    {
        
        /// <summary>
        /// Specific action name for security operation. Values:
        /// <li>`Deny`: block</li> <li>`Monitor`: monitor</li> <li>`ReturnCustomPage`: block with customized page</li> <li>`Redirect`: Redirect to URL</li> <li>`BlockIP`: IP block</li> <li>`JSChallenge`: javaScript challenge</li> <li>`ManagedChallenge`: managed challenge</li> <li>`Disabled`: disabled</li> <li>`Allow`: allow</li>.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Additional parameter when Name is BlockIP.
        /// </summary>
        [JsonProperty("BlockIPActionParameters")]
        public BlockIPActionParameters BlockIPActionParameters{ get; set; }

        /// <summary>
        /// Additional parameter when Name is ReturnCustomPage.
        /// </summary>
        [JsonProperty("ReturnCustomPageActionParameters")]
        public ReturnCustomPageActionParameters ReturnCustomPageActionParameters{ get; set; }

        /// <summary>
        /// Additional parameter when Name is Redirect.
        /// </summary>
        [JsonProperty("RedirectActionParameters")]
        public RedirectActionParameters RedirectActionParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "BlockIPActionParameters.", this.BlockIPActionParameters);
            this.SetParamObj(map, prefix + "ReturnCustomPageActionParameters.", this.ReturnCustomPageActionParameters);
            this.SetParamObj(map, prefix + "RedirectActionParameters.", this.RedirectActionParameters);
        }
    }
}

