// 2016

function serverCmdTumble(%client, %vel1, %vel2, %vel3) {
    if(!isObject(%player = %client.player))
        return;
    %player.setVelocity(%vel = %vel1 SPC %vel2 SPC %vel3);
    %player.tumble();
    %client.isTumbling = 1;
}
function serverCmdUnTumble(%client) {
    if(%client.isTumbling) {
        %client.isTumbling = 0;
        %client.createPlayer(%pos = %player.getPosition());
        return %player.delete();
    }
    else
        return;
}
