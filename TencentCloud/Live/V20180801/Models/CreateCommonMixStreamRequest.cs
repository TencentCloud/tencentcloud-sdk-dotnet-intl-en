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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCommonMixStreamRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of stream mix session (from applying for stream mix to canceling stream mix).
        /// </summary>
        [JsonProperty("MixStreamSessionId")]
        public string MixStreamSessionId{ get; set; }

        /// <summary>
        /// Input stream list for stream mix.
        /// </summary>
        [JsonProperty("InputStreamList")]
        public CommonMixInputParam[] InputStreamList{ get; set; }

        /// <summary>
        /// Output stream parameter for stream mix.
        /// </summary>
        [JsonProperty("OutputParams")]
        public CommonMixOutputParams OutputParams{ get; set; }

        /// <summary>
        /// Input template ID. If this parameter is set, the output will be generated according to the default template layout, and there is no need to enter the custom position parameters.
        /// If this parameter is left empty, 0 will be used by default.
        /// For two input sources, 10, 20, 30, 40, and 50 are supported.
        /// For three input sources, 310, 390, and 391 are supported.
        /// For four input sources, 410 is supported.
        /// For five input sources, 510 and 590 are supported.
        /// For six input sources, 610 is supported.
        /// </summary>
        [JsonProperty("MixStreamTemplateId")]
        public long? MixStreamTemplateId{ get; set; }

        /// <summary>
        /// Special control parameter for stream mix. If there are no special needs, leave it empty.
        /// </summary>
        [JsonProperty("ControlParams")]
        public CommonMixControlParams ControlParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MixStreamSessionId", this.MixStreamSessionId);
            this.SetParamArrayObj(map, prefix + "InputStreamList.", this.InputStreamList);
            this.SetParamObj(map, prefix + "OutputParams.", this.OutputParams);
            this.SetParamSimple(map, prefix + "MixStreamTemplateId", this.MixStreamTemplateId);
            this.SetParamObj(map, prefix + "ControlParams.", this.ControlParams);
        }
    }
}

