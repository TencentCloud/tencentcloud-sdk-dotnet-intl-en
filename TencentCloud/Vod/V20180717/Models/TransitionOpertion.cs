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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransitionOpertion : AbstractModel
    {
        
        /// <summary>
        /// Transition type. Valid values:
        /// <ul>
        /// <li>Video image transition operation, which is used for transition with video image between two video segments:
        /// <ul>
        /// <li>ImageFadeInFadeOut: video image fade-in/fade-out.</li>
        /// <li>BowTieHorizontal: horizontal bow.</li>
        /// <li>BowTieVertical: vertical bow.</li>
        /// <li>ButterflyWaveScrawler: waggling.</li>
        /// <li>Cannabisleaf: maple leaf.</li>
        /// <li> Circle: curved circling.</li>
        /// <li>CircleCrop: circle gathering.</li>
        /// <li>Circleopen: elliptic gathering.</li>
        /// <li>Crosswarp: horizontal warping.</li>
        /// <li>Cube: cube.</li>
        /// <li>DoomScreenTransition: curtain.</li>
        /// <li>Doorway: doorway.</li>
        /// <li>Dreamy: wave.</li>
        /// <li>DreamyZoom: horizontal gathering.</li>
        /// <li>FilmBurn: evening glow.</li>
        /// <li>GlitchMemories: joggling.</li>
        /// <li>Heart: heart.</li>
        /// <li>InvertedPageCurl: page turning.</li>
        /// <li>Luma: corroding.</li>
        /// <li>Mosaic: grid.</li>
        /// <li>Pinwheel: pinwheel.</li>
        /// <li>PolarFunction: elliptic diffusing.</li>
        /// <li>PolkaDotsCurtain: curved diffusing.</li>
        /// <li>Radial: radar scan.</li>
        /// <li>RotateScaleFade: vertical rotating.</li>
        /// <li>Squeeze: vertical gathering.</li>
        /// <li>Swap: zooming in.</li>
        /// <li>Swirl: swirling.</li>
        /// <li>UndulatingBurnOutSwirl: water spreading.</li>
        /// <li>Windowblinds: blinds.</li>
        /// <li>WipeDown: collapsing down.</li>
        /// <li>WipeLeft: collapsing to the left.</li>
        /// <li>WipeRight: collapsing to the right.</li>
        /// <li>WipeUp: collapsing up.</li>
        /// <li>ZoomInCircles: ripples.</li>
        /// </ul>
        /// </li>
        /// <li>Audio transition operation, which is used for transition between two audio segments:
        /// <ul>
        /// <li>AudioFadeInFadeOut: audio fade-in/fade-out.</li>
        /// </ul>
        /// </li>
        /// </ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

