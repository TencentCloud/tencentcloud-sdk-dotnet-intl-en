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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoScalingGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Scaling group ID. obtain available scaling group ids in the following ways:</p><li>query scaling group ids by logging in to the <a href="https://console.cloud.tencent.com/autoscaling/group">console</a>.</li><li>obtain scaling group ids by calling the <a href="https://www.tencentcloud.comom/document/api/377/20438?from_cn_redirect=1">DescribeAutoScalingGroups</a> api and retrieving AutoScalingGroupId from the returned information.</li>.
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// <p>The scaling group name must be unique in your account. name only supports chinese, english, digits, underscore, separator "-", and decimal point. the maximum length cannot exceed 55 bytes.</p>.
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// <P>Default cooldown in seconds, value ranges from 0 to 3600, default value is 300.</p>.
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public ulong? DefaultCooldown{ get; set; }

        /// <summary>
        /// <P>Expected number of instances. value range [0,2000]. to meet the maximum value equal to or greater than the expected value, and the expected value equal to or greater than the minimum value.</p>.
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// <p>Launch configuration ID. obtain available launch configuration ids in the following ways:</p><li>query the launch configuration ID by logging in to the <a href="https://console.cloud.tencent.com/autoscaling/config">console</a>.</li><li>obtain the launch configuration ID by calling the <a href="https://www.tencentcloud.comom/document/api/377/20445?from_cn_redirect=1">DescribeLaunchConfigurations</a> api and retrieving the LaunchConfigurationId from the returned information.</li>.
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// <P>Maximum number of instances. value range: [0,2000]. to meet the requirement, the maximum value must be equal to or greater than the expected value, and the expected value must be equal to or greater than the minimum value.</p>.
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <P>Minimum number of instances. value range: [0,2000]. to meet the requirement, the maximum value must be equal to or greater than the expected value, and the expected value must be equal to or greater than the minimum value.</p>.
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// <p>Project ID. obtain this parameter by calling the `ProjectId` field in the return value of <a href="https://www.tencentcloud.comom/document/api/651/78725?from_cn_redirect=1">DescribeProject</a>. default value is 0, indicating usage of the default project.</p>.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>subnet ID list. valid vpc subnet ids can be obtained by logging in to the <a href="https://console.cloud.tencent.com/vpc/subnet">console</a> for querying. you can also call the API <a href="https://www.tencentcloud.comom/document/product/215/15784?from_cn_redirect=1">DescribeSubnets</a> and retrieve them from the SubnetId field in the API response.</p>.
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// <p>Termination policy, whose maximum length is currently 1. valid values: OLDEST_INSTANCE and NEWEST_INSTANCE.</p><li> OLDEST_INSTANCE terminates the OLDEST INSTANCE in the scaling group first.</li><li> NEWEST_INSTANCE terminates the NEWEST INSTANCE in the scaling group first.</li>.
        /// </summary>
        [JsonProperty("TerminationPolicies")]
        public string[] TerminationPolicies{ get; set; }

        /// <summary>
        /// <p>vpc ID. when modifying the vpc, you need to change the SubnetIds parameter to the subnet of this vpc. effective VpcId can be queried by logging in to the <a href="https://console.cloud.tencent.com/vpc/vpc">console</a>; you can also call the <a href="https://www.tencentcloud.comom/document/api/215/15778?from_cn_redirect=1">DescribeVpc</a> api and get the VpcId field from the api response.</p>.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <P>AZ list</p>.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>RETRY policy, whose valid values include IMMEDIATE_RETRY, INCREMENTAL_INTERVALS, and NO_RETRY, with the default value being IMMEDIATE_RETRY. a partially successful scaling operation is considered a failed activity.</p><li>IMMEDIATE_RETRY: RETRY immediately, attempting retries in rapid succession over a short period, and cease further retries after a certain number of consecutive failures (5 times).</li><li>INCREMENTAL_INTERVALS: INCREMENTAL interval RETRY, with the RETRY interval gradually increasing as the number of consecutive failures rises, ranging from seconds to 1 day.</li><li>NO_RETRY: NO RETRY until a user call or Alarm information is received again.</li>.
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// <p>Availability Zone validation policy. valid values include ALL and ANY. default value: ANY. it is effective when scaling group actual change resource-related fields (launch configuration, az, subnet) are modified.</p><li> ALL: verification passes if ALL azs (Zone) or subnets (SubnetId) are available. otherwise, a verification error will be reported.</li><li> ANY: verification passes if ANY AZ (Zone) or subnet (SubnetId) is available. otherwise, a verification error will be reported.</li><p>common causes for unavailable azs or subnets include CVM instancetype sold out in the az, CBS cloud disk sold out in the az, insufficient quota in the az, or insufficient IP addresses in the subnet.</p><p>if Zones/SubnetIds contain nonexistent azs or subnets, a verification error will be reported regardless of the values of ZonesCheckPolicy.</p>.
        /// </summary>
        [JsonProperty("ZonesCheckPolicy")]
        public string ZonesCheckPolicy{ get; set; }

        /// <summary>
        /// <P>Service settings, including cloud monitoring and unhealthy instance replacement.</p>.
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// <p>The instance has a configuration for the number of IPv6 addresses. valid values include 0 and 1. the default value is 0, which means the instance does not allocate an IPv6 address. you need to use a VPC that supports IPv6 and enable IPv6 CIDR in the subnet.</p>
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// <p>The multi-az/subnet policy, with values including PRIORITY and EQUALITY, defaults to PRIORITY.</p><li> PRIORITY: attempt to create instances taking the order of the az/subnet list as the PRIORITY. if instances can be successfully created in the az/subnet with the highest PRIORITY, they will always be created there.</li> <li> EQUALITY: instances added through scale-out will be distributed across multiple azs/subnets to ensure A relatively balanced number of instances in each az/subnet after expansion.</li> <p>points to consider:</p><li> when the scaling group is based on A classic network, this policy applies to multi-az. when the scaling group is based on A VPC network, this policy applies to multi-subnet, no longer considering AZ factors. for example, with four subnets labeled A, B, c, and D, where A, B, and c are in availability zone 1 and D is in availability zone 2, consider subnets A, B, c, and D for sorting, without considering availability zones 1 and 2.</li> <li> this policy applies to multi-az/subnet but is not applicable to the instancetypes parameter of the launch configuration. selection of multiple models is according to PRIORITY policy.</li> <li> when creating instances according to the PRIORITY policy, ensure the policy for multiple models first, then the policy for multi-az/subnet. for example, with multiple models A and B, and multiple subnets 1, 2, and 3, attempts will be made in the order A1, A2, A3, B1, B2, B3. if A1 is sold out, A2 will be attempted (not B1).</li>.
        /// </summary>
        [JsonProperty("MultiZoneSubnetPolicy")]
        public string MultiZoneSubnetPolicy{ get; set; }

        /// <summary>
        /// <p>Scaling group instance health check type, values are as follows:</p><li>CVM: determine whether an instance is unhealthy based on its network status. an unhealthy network status refers to an event where instances become unreachable via PING. for detailed criteria of judgment, refer to [instance health check](https://www.tencentcloud.comom/document/product/377/8553?from_cn_redirect=1).</li><li>CLB: determine whether an instance is unhealthy based on the health check status of CLB. for the principle of CLB health check, see [health check](https://www.tencentcloud.comom/document/product/214/6097?from_cn_redirect=1).</li>.
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// <p>Specifies the CLB health check grace period in seconds.</p><p>value range: [0, 7200].</p><p>default value: 0.</p>
        /// </summary>
        [JsonProperty("LoadBalancerHealthCheckGracePeriod")]
        public ulong? LoadBalancerHealthCheckGracePeriod{ get; set; }

        /// <summary>
        /// <p>Instance allocation policy. valid values include LAUNCH_CONFIGURATION and SPOT_MIXED.</p><li> LAUNCH_CONFIGURATION represents the traditional startup CONFIGURATION mode.</li><li> SPOT_MIXED represents the SPOT hybrid mode. currently only support hybrid mode when the LAUNCH CONFIGURATION uses pay-as-you-go billing mode. in hybrid mode, the scaling group will scale out based on the SPOT model. the billing type of the associated LAUNCH CONFIGURATION cannot be modified when using hybrid mode.</li>.
        /// </summary>
        [JsonProperty("InstanceAllocationPolicy")]
        public string InstanceAllocationPolicy{ get; set; }

        /// <summary>
        /// <p>Allocation policy of instances for each billing type in SPOT hybrid mode.<br>available only when InstanceAllocationPolicy is set to SPOT_MIXED.</p>.
        /// </summary>
        [JsonProperty("SpotMixedAllocationPolicy")]
        public SpotMixedAllocationPolicy SpotMixedAllocationPolicy{ get; set; }

        /// <summary>
        /// <p>The capacity rebalancing feature is only applicable to spot instances within the scaling group. valid values:</p><li> TRUE: enable this feature. when spot instances within the scaling group are about to be automatically recycled by the spot instance service, AS initiates the termination process of spot instances. if a scale-in hook is configured, trigger before termination. after the termination process starts, AS asynchronously initiates scale-out to reach the expected number of instances.</li> <li> FALSE: disable this feature. AS waits for the spot instance to be terminated before scaling out to reach the number of instances expected by the scaling group.</li>.
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public bool? CapacityRebalance{ get; set; }

        /// <summary>
        /// <P>Instance name sequencing settings. once enabled, append incremental numeric sequence to the names of instances automatically created within the scaling group.</p>.
        /// </summary>
        [JsonProperty("InstanceNameIndexSettings")]
        public InstanceNameIndexSettings InstanceNameIndexSettings{ get; set; }

        /// <summary>
        /// <P>Instance hostname sequencing settings. once enabled, append incremental numeric sequence to the hostname of instances automatically created within the scaling group.</p>.
        /// </summary>
        [JsonProperty("HostNameIndexSettings")]
        public HostNameIndexSettings HostNameIndexSettings{ get; set; }

        /// <summary>
        /// <p>The concurrent scaling up functionality for matching expected numbers cannot be set when InstanceAllocationPolicy is in spot hybrid mode or when ScalingMode is in the scaling-prioritized startup mode. currently only two matching expected number scale-out activities are supported to run concurrently. other types of activities such as specified quantity scale-out or scale-in cannot be specified. set to FALSE indicates disabled.</p>.
        /// </summary>
        [JsonProperty("ConcurrentScaleOutForDesiredCapacity")]
        public bool? ConcurrentScaleOutForDesiredCapacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "TerminationPolicies.", this.TerminationPolicies);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ZonesCheckPolicy", this.ZonesCheckPolicy);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamSimple(map, prefix + "MultiZoneSubnetPolicy", this.MultiZoneSubnetPolicy);
            this.SetParamSimple(map, prefix + "HealthCheckType", this.HealthCheckType);
            this.SetParamSimple(map, prefix + "LoadBalancerHealthCheckGracePeriod", this.LoadBalancerHealthCheckGracePeriod);
            this.SetParamSimple(map, prefix + "InstanceAllocationPolicy", this.InstanceAllocationPolicy);
            this.SetParamObj(map, prefix + "SpotMixedAllocationPolicy.", this.SpotMixedAllocationPolicy);
            this.SetParamSimple(map, prefix + "CapacityRebalance", this.CapacityRebalance);
            this.SetParamObj(map, prefix + "InstanceNameIndexSettings.", this.InstanceNameIndexSettings);
            this.SetParamObj(map, prefix + "HostNameIndexSettings.", this.HostNameIndexSettings);
            this.SetParamSimple(map, prefix + "ConcurrentScaleOutForDesiredCapacity", this.ConcurrentScaleOutForDesiredCapacity);
        }
    }
}

