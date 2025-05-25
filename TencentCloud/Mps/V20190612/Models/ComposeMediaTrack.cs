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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComposeMediaTrack : AbstractModel
    {
        
        /// <summary>
        /// Track type. Valid values: <ul><li>Video: video track. It can consist of the following elements:</li><ul><li>Video elements</li><li>Image elements</li><li>Transition elements</li><li>Empty elements</li></ul><li>Audio: audio track. It can consist of the following elements:</li><ul><li>Audio elements</li><li>Transition elements</li><li>Empty elements</li></ul><li>Title: text track. It can consist of the following elements:</li><ul><li>Subtitle elements</li></ul></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The elements of a track.
        /// </summary>
        [JsonProperty("Items")]
        public ComposeMediaItem[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
        }
    }
}

