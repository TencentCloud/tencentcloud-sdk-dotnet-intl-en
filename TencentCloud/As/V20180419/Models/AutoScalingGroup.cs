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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScalingGroup : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Auto scaling group name
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// Current scaling group status. Valid values:<br>
        /// <li>NORMAL: Normal<br>
        /// <li>CVM_ABNORMAL: Abnormal launch configuration<br>
        /// <li>LB_ABNORMAL: Abnormal load balancer<br>
        /// <li>LB_LISTENER_ABNORMAL: Abnormal load balancer listener<br>
        /// <li>LB_LOCATION_ABNORMAL: Abnormal forwarding configuration of the load balancer listener<br>
        /// <li>VPC_ABNORMAL: VPC network error<br>
        /// <li>SUBNET_ABNORMAL: VPC subnet exception<br>
        /// <li>INSUFFICIENT_BALANCE: Insufficient account balance<br>
        /// <li>LB_BACKEND_REGION_NOT_MATCH: The CLB backend and the AS service are not in the same region.<br>
        /// <li>LB_BACKEND_VPC_NOT_MATCH: The CLB instance and the scaling group are not in the same VPC.
        /// </summary>
        [JsonProperty("AutoScalingGroupStatus")]
        public string AutoScalingGroupStatus{ get; set; }

        /// <summary>
        /// Creation time in UTC format
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Default cooldown period in seconds
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public long? DefaultCooldown{ get; set; }

        /// <summary>
        /// Desired number of instances
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public long? DesiredCapacity{ get; set; }

        /// <summary>
        /// Enabled status. Value range: `ENABLED`, `DISABLED`
        /// </summary>
        [JsonProperty("EnabledStatus")]
        public string EnabledStatus{ get; set; }

        /// <summary>
        /// List of application load balancers
        /// </summary>
        [JsonProperty("ForwardLoadBalancerSet")]
        public ForwardLoadBalancer[] ForwardLoadBalancerSet{ get; set; }

        /// <summary>
        /// Number of instances
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Number of instances in `IN_SERVICE` status
        /// </summary>
        [JsonProperty("InServiceInstanceCount")]
        public long? InServiceInstanceCount{ get; set; }

        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Launch configuration name
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// List of Classic load balancer IDs
        /// </summary>
        [JsonProperty("LoadBalancerIdSet")]
        public string[] LoadBalancerIdSet{ get; set; }

        /// <summary>
        /// Maximum number of instances
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// Minimum number of instances
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// List of subnet IDs
        /// </summary>
        [JsonProperty("SubnetIdSet")]
        public string[] SubnetIdSet{ get; set; }

        /// <summary>
        /// Termination policy
        /// </summary>
        [JsonProperty("TerminationPolicySet")]
        public string[] TerminationPolicySet{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// List of availability zones
        /// </summary>
        [JsonProperty("ZoneSet")]
        public string[] ZoneSet{ get; set; }

        /// <summary>
        /// Retry policy
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// Whether the auto scaling group is performing a scaling activity. `IN_ACTIVITY` indicates yes, and `NOT_IN_ACTIVITY` indicates no.
        /// </summary>
        [JsonProperty("InActivityStatus")]
        public string InActivityStatus{ get; set; }

        /// <summary>
        /// List of auto scaling group tags
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Service settings
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// The number of IPv6 addresses that an instance has.
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// The policy applied when there are multiple availability zones/subnets
        /// <br><li> PRIORITY: when creating instances, choose the availability zone/subnet based on the order in the list from top to bottom. If the first instance is successfully created in the availability zone/subnet of the highest priority, all instances will be created in this availability zone/subnet.
        /// <br><li> EQUALITY: chooses the availability zone/subnet with the least instances for scale-out. This gives each availability zone/subnet an opportunity for scale-out and disperses the instances created during multiple scale-out operations across different availability zones/subnets.
        /// </summary>
        [JsonProperty("MultiZoneSubnetPolicy")]
        public string MultiZoneSubnetPolicy{ get; set; }

        /// <summary>
        /// Health check type of instances in a scaling group.<br><li>CVM: confirm whether an instance is healthy based on the network status. If the pinged instance is unreachable, the instance will be considered unhealthy. For more information, see [Instance Health Check](https://intl.cloud.tencent.com/document/product/377/8553?from_cn_redirect=1)<br><li>CLB: confirm whether an instance is healthy based on the CLB health check status. For more information, see [Health Check Overview](https://intl.cloud.tencent.com/document/product/214/6097?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// Grace period of the CLB health check
        /// </summary>
        [JsonProperty("LoadBalancerHealthCheckGracePeriod")]
        public ulong? LoadBalancerHealthCheckGracePeriod{ get; set; }

        /// <summary>
        /// Specifies how to assign instances. Valid values: `LAUNCH_CONFIGURATION` and `SPOT_MIXED`.
        /// <br><li>`LAUNCH_CONFIGURATION`: the launch configuration mode.
        /// <br><li>`SPOT_MIXED`: a mixed instance mode. Currently, this mode is supported only when the launch configuration takes the pay-as-you-go billing mode. With this mode, the scaling group can provision a combination of pay-as-you-go instances and spot instances to meet the configured capacity. Note that the billing mode of the associated launch configuration cannot be modified when this mode is used.
        /// </summary>
        [JsonProperty("InstanceAllocationPolicy")]
        public string InstanceAllocationPolicy{ get; set; }

        /// <summary>
        /// Specifies how to assign pay-as-you-go instances and spot instances.
        /// A valid value will be returned only when `InstanceAllocationPolicy` is set to `SPOT_MIXED`.
        /// </summary>
        [JsonProperty("SpotMixedAllocationPolicy")]
        public SpotMixedAllocationPolicy SpotMixedAllocationPolicy{ get; set; }

        /// <summary>
        /// Indicates whether the capacity rebalancing feature is enabled. This parameter is only valid for spot instances in the scaling group. Valid values:
        /// <br><li>`TRUE`: yes. Before the spot instances in the scaling group are about to be automatically repossessed, AS will terminate them. The scale-in hook (if configured) will take effect before the termination. After the termination process starts, AS will asynchronously initiate a scaling activity to meet the desired capacity.
        /// <br><li>`FALSE`: no. AS will add instances to meet the desired capacity only after the spot instances are terminated.
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public bool? CapacityRebalance{ get; set; }

        /// <summary>
        /// Instance name sequencing settings.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceNameIndexSettings")]
        public InstanceNameIndexSettings InstanceNameIndexSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupStatus", this.AutoScalingGroupStatus);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "EnabledStatus", this.EnabledStatus);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancerSet.", this.ForwardLoadBalancerSet);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "InServiceInstanceCount", this.InServiceInstanceCount);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIdSet.", this.LoadBalancerIdSet);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SubnetIdSet.", this.SubnetIdSet);
            this.SetParamArraySimple(map, prefix + "TerminationPolicySet.", this.TerminationPolicySet);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "ZoneSet.", this.ZoneSet);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "InActivityStatus", this.InActivityStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamSimple(map, prefix + "MultiZoneSubnetPolicy", this.MultiZoneSubnetPolicy);
            this.SetParamSimple(map, prefix + "HealthCheckType", this.HealthCheckType);
            this.SetParamSimple(map, prefix + "LoadBalancerHealthCheckGracePeriod", this.LoadBalancerHealthCheckGracePeriod);
            this.SetParamSimple(map, prefix + "InstanceAllocationPolicy", this.InstanceAllocationPolicy);
            this.SetParamObj(map, prefix + "SpotMixedAllocationPolicy.", this.SpotMixedAllocationPolicy);
            this.SetParamSimple(map, prefix + "CapacityRebalance", this.CapacityRebalance);
            this.SetParamObj(map, prefix + "InstanceNameIndexSettings.", this.InstanceNameIndexSettings);
        }
    }
}

