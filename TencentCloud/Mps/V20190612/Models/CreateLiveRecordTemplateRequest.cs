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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveRecordTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// HLS configuration parameter. Either this parameter or MP4Configure should be specified.
        /// </summary>
        [JsonProperty("HLSConfigure")]
        public HLSConfigureInfo HLSConfigure{ get; set; }

        /// <summary>
        /// MP4 configuration parameter. Either this parameter or HLSConfigure should be specified.
        /// </summary>
        [JsonProperty("MP4Configure")]
        public MP4ConfigureInfo MP4Configure{ get; set; }

        /// <summary>
        /// Recording template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description, with a length limit of 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "HLSConfigure.", this.HLSConfigure);
            this.SetParamObj(map, prefix + "MP4Configure.", this.MP4Configure);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

